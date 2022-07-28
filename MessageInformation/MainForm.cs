using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

using WhatsappMessageCounterLibrary.Counter;
using WhatsappMessageCounterLibrary.Data_Classes;

using Squirrel;
// ReSharper disable LocalizableElement

namespace MessageInformation
{
    public partial class MainForm : Form
    {
        private Config config;
        private Dictionary<string, string> _specialCases = new ();
        private string fileName = "";
        private bool Scanning { get; set; }
        public MainForm()
        {
            InitializeComponent();
            InitializeProperties();

            AddVersionNumber();

            CheckForUpdates();
        }

        private void InitializeProperties() { config = new Config(false); }

        private void AddVersionNumber()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $" v.{versionInfo.FileVersion}";

        }

        private async Task CheckForUpdates()
        {
            using var manager = new UpdateManager(@"D:\Deploy\Whatsapp Counter framework dependent");
            await manager.UpdateApp();
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = fileDialog.FileName;
            fileChosenLabel.Text = "File Chosen: " + filePath;
            var first50Lines = File.ReadLines(filePath).Take(50).ToList().Aggregate("",
                 (accumulated, element) => accumulated + element + "\n");
            fileContentPreviewRichTb.Text = first50Lines;
            fileName = filePath;
        }

        private void dateLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            var maxLength = dateLengthTrackBar.Value;
            dateLengthLabel.Text = "Date Length: " + maxLength;
            config.DateMaxLength = maxLength;
        }

        private void saveAsFromatCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.SaveOption = ((string) saveAsFromatCombox.SelectedItem).ToLower() switch
            { "none"            => SaveOption.None,
              "normal"          => SaveOption.Normal,
              "json"            => SaveOption.Json,
              "json and normal" => SaveOption.JsonAndNormal,
              _                 => config.SaveOption };
        }


        #region Special Cases

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            var cells = dataGridView1.Rows[e.RowIndex].Cells;
            var cellText = cells[e.ColumnIndex].Value as string ?? string.Empty;
            var colToCheck = e.ColumnIndex == 0 ? 1 : 0;

            var secondaryValue = cells[colToCheck].Value as string;

            if (cellText != string.Empty &&
                !string.IsNullOrEmpty(secondaryValue))
            {
                if (cells[0].Tag != null && !_specialCases.ContainsKey(cells[0].Value as string ?? ""))
                {
                    _specialCases.Remove(cells[0].Tag as string);
                    _specialCases.Add(cells[0].Value as string, cells[1].Value as string);
                    cells[0].Tag = cells[0].Value as string;
                    cells[1].Tag = cells[1].Value as string;
                }
                else if (!_specialCases.ContainsKey(cells[0].Value as string ?? ""))
                {
                    _specialCases.Add(cells[0].Value as string, cells[1].Value as string);
                    cells[0].Tag = cells[0].Value as string;
                    cells[1].Tag = cells[1].Value as string;
                }
                else if (e.ColumnIndex == 1)
                {
                    _specialCases[cells[0].Value as string] = cells[1].Value as string;
                    cells[0].Tag = cells[0].Value as string;
                    cells[1].Tag = cells[1].Value as string;
                }
                else
                {
                    MessageBox.Show($"Key with the value of: {cells[0].Value as string} already exists");
                    cells[e.ColumnIndex].Value = "";
                    cells[e.ColumnIndex].Tag = null;
                    cells[colToCheck].Value = "";
                    cells[e.ColumnIndex].Tag = null;
                }
            }
            else if (cells[0].Tag != null)
            {
                _specialCases.Remove(cells[0].Tag as string);
                cells[0].Tag = null;
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var value = e.Row.Cells[0].Tag as string ?? string.Empty;
            if (_specialCases.ContainsKey(value)) _specialCases.Remove(value);
        }

        #endregion
        
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Scanning)
            {
                Error("Unable to scan whilst scanning a file.");
                return;
            }

            Scanning = true;
            if (fileName == null)
            {
                Error("Upload a file first!");
                return;
            }

            var resultFileName = resultFileNameTextBox.Text;

            if (saveAsFromatCombox.SelectedItem == null)
            {
                Error("Must enter format to save as");
                return;
            }

            if (config.SaveOption != SaveOption.None && resultFileName == string.Empty)
            {
                Error("Must enter result file name or set save as to \"None\"");
                return;
            }

            var txtExits = File.Exists(config.AppDataPath + resultFileName + ".txt");
            var jsonExists = File.Exists(config.AppDataPath + resultFileName + ".json");
            var shouldTxt = config.SaveOption is SaveOption.Normal or SaveOption.JsonAndNormal;
            var shouldJson = config.SaveOption is SaveOption.Json or SaveOption.JsonAndNormal;

            if ((txtExits && shouldTxt) || (shouldJson && jsonExists))
            {
                Error($"File with the name: {resultFileName} already exits. Please choose a different name.");
                return;
            }
            dataGridView2.Rows.Clear();
            var mc = new MessageCounter(config);
            Cursor = Cursors.WaitCursor;
            mc.OnProgressChanged += (o, information) => {
                Invoke(() => progressBar1.Value = information.Precentage);
            };
            var results = await mc.ScanMessagesAsync(fileName, resultFileName, _specialCases);
            Cursor = Cursors.Default;

            foreach (var record in results.SortedRecords)
            {
                dataGridView2.Rows.Add(record.Key, record.Value.TotalMessages, record.Value.TotalWords);
            }

            totalMessagesLabel.Text = "Total Messages: " + results.TotalMessages;
            totalWordsLabel.Text = "Total Words: " + results.TotalWords;
            
            if (File.Exists(results.SavedIn) || results.SavedIn != "Configured to not save")
            {
                MessageBox.Show($"Successfully saved results into: {results.SavedIn}");
            }

            progressBar1.Value = 0;
            Scanning = false;
        }

        private static void Error(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

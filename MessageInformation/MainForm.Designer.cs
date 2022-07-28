namespace MessageInformation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.fileContentPreviewRichTb = new System.Windows.Forms.RichTextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileChosenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLengthLabel = new System.Windows.Forms.Label();
            this.dateLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveAsFromatCombox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultFileNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.totalMessagesLabel = new System.Windows.Forms.Label();
            this.totalWordsLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMessages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateLengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.AutoSize = true;
            this.uploadFileButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.uploadFileButton.BackgroundImage = global::MessageInformation.Properties.Resources._04547c2b354abb70a85ed8a2d1b33e5f;
            this.uploadFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadFileButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadFileButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.uploadFileButton.Location = new System.Drawing.Point(12, 9);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(234, 46);
            this.uploadFileButton.TabIndex = 0;
            this.uploadFileButton.Text = "Upload      File";
            this.uploadFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadFileButton.UseVisualStyleBackColor = false;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            // 
            // fileContentPreviewRichTb
            // 
            this.fileContentPreviewRichTb.Location = new System.Drawing.Point(12, 78);
            this.fileContentPreviewRichTb.Name = "fileContentPreviewRichTb";
            this.fileContentPreviewRichTb.ReadOnly = true;
            this.fileContentPreviewRichTb.Size = new System.Drawing.Size(232, 251);
            this.fileContentPreviewRichTb.TabIndex = 1;
            this.fileContentPreviewRichTb.Text = "";
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Text files |*.txt";
            this.fileDialog.Title = "Choose a source file";
            // 
            // fileChosenLabel
            // 
            this.fileChosenLabel.AutoSize = true;
            this.fileChosenLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileChosenLabel.Location = new System.Drawing.Point(12, 332);
            this.fileChosenLabel.MaximumSize = new System.Drawing.Size(232, 0);
            this.fileChosenLabel.Name = "fileChosenLabel";
            this.fileChosenLabel.Size = new System.Drawing.Size(187, 14);
            this.fileChosenLabel.TabIndex = 2;
            this.fileChosenLabel.Text = "File Chosen: No file Chosen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.MaximumSize = new System.Drawing.Size(232, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Preview:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(252, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 489);
            this.label2.TabIndex = 4;
            // 
            // optionsLabel
            // 
            this.optionsLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.optionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.optionsLabel.Location = new System.Drawing.Point(260, 9);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(232, 46);
            this.optionsLabel.TabIndex = 5;
            this.optionsLabel.Text = "Options";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(498, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 489);
            this.label3.TabIndex = 6;
            // 
            // dateLengthLabel
            // 
            this.dateLengthLabel.AutoSize = true;
            this.dateLengthLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLengthLabel.Location = new System.Drawing.Point(260, 61);
            this.dateLengthLabel.MaximumSize = new System.Drawing.Size(232, 0);
            this.dateLengthLabel.Name = "dateLengthLabel";
            this.dateLengthLabel.Size = new System.Drawing.Size(114, 14);
            this.dateLengthLabel.TabIndex = 7;
            this.dateLengthLabel.Text = "Date Length: 15";
            // 
            // dateLengthTrackBar
            // 
            this.dateLengthTrackBar.Location = new System.Drawing.Point(260, 78);
            this.dateLengthTrackBar.Maximum = 20;
            this.dateLengthTrackBar.Minimum = 10;
            this.dateLengthTrackBar.Name = "dateLengthTrackBar";
            this.dateLengthTrackBar.Size = new System.Drawing.Size(232, 45);
            this.dateLengthTrackBar.TabIndex = 8;
            this.dateLengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.dateLengthTrackBar.Value = 15;
            this.dateLengthTrackBar.Scroll += new System.EventHandler(this.dateLengthTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(260, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 2);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(260, 139);
            this.label5.MaximumSize = new System.Drawing.Size(232, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Save Results:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(260, 164);
            this.label6.MaximumSize = new System.Drawing.Size(232, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Save results as..";
            // 
            // saveAsFromatCombox
            // 
            this.saveAsFromatCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveAsFromatCombox.Items.AddRange(new object[] {
            "None",
            "Json",
            "Normal",
            "Json and Normal"});
            this.saveAsFromatCombox.Location = new System.Drawing.Point(378, 161);
            this.saveAsFromatCombox.Name = "saveAsFromatCombox";
            this.saveAsFromatCombox.Size = new System.Drawing.Size(114, 23);
            this.saveAsFromatCombox.TabIndex = 12;
            this.saveAsFromatCombox.SelectedIndexChanged += new System.EventHandler(this.saveAsFromatCombox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(260, 187);
            this.label7.MaximumSize = new System.Drawing.Size(232, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Save results name:";
            // 
            // resultFileNameTextBox
            // 
            this.resultFileNameTextBox.Location = new System.Drawing.Point(260, 206);
            this.resultFileNameTextBox.MaxLength = 30;
            this.resultFileNameTextBox.Name = "resultFileNameTextBox";
            this.resultFileNameTextBox.PlaceholderText = "Enter Result File Name..";
            this.resultFileNameTextBox.Size = new System.Drawing.Size(232, 23);
            this.resultFileNameTextBox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Replacement});
            this.dataGridView1.Location = new System.Drawing.Point(260, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(232, 222);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Names
            // 
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            // 
            // Replacement
            // 
            this.Replacement.HeaderText = "Replacement";
            this.Replacement.Name = "Replacement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(260, 242);
            this.label8.MaximumSize = new System.Drawing.Size(232, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name Replacements:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.BackgroundImage = global::MessageInformation.Properties.Resources.go_arrow_next_up_green_forward_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(551, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "    Run       Scan ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(506, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // totalMessagesLabel
            // 
            this.totalMessagesLabel.AutoSize = true;
            this.totalMessagesLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalMessagesLabel.Location = new System.Drawing.Point(506, 96);
            this.totalMessagesLabel.MaximumSize = new System.Drawing.Size(232, 0);
            this.totalMessagesLabel.Name = "totalMessagesLabel";
            this.totalMessagesLabel.Size = new System.Drawing.Size(119, 14);
            this.totalMessagesLabel.TabIndex = 19;
            this.totalMessagesLabel.Text = "Total messages: -";
            // 
            // totalWordsLabel
            // 
            this.totalWordsLabel.AutoSize = true;
            this.totalWordsLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalWordsLabel.Location = new System.Drawing.Point(506, 114);
            this.totalWordsLabel.MaximumSize = new System.Drawing.Size(232, 0);
            this.totalWordsLabel.Name = "totalWordsLabel";
            this.totalWordsLabel.Size = new System.Drawing.Size(95, 14);
            this.totalWordsLabel.TabIndex = 20;
            this.totalWordsLabel.Text = "Total Words: -";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TotalMessages,
            this.TotalWords});
            this.dataGridView2.Location = new System.Drawing.Point(506, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(325, 350);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TotalMessages
            // 
            this.TotalMessages.HeaderText = "TotalMessages";
            this.TotalMessages.Name = "TotalMessages";
            this.TotalMessages.ReadOnly = true;
            // 
            // TotalWords
            // 
            this.TotalWords.HeaderText = "TotalWords";
            this.TotalWords.Name = "TotalWords";
            this.TotalWords.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 493);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.totalWordsLabel);
            this.Controls.Add(this.totalMessagesLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resultFileNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveAsFromatCombox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateLengthTrackBar);
            this.Controls.Add(this.dateLengthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileChosenLabel);
            this.Controls.Add(this.fileContentPreviewRichTb);
            this.Controls.Add(this.uploadFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(859, 532);
            this.MinimumSize = new System.Drawing.Size(859, 532);
            this.Name = "MainForm";
            this.Text = "Whatsapp message counter";
            ((System.ComponentModel.ISupportInitialize)(this.dateLengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uploadFileButton;
        private RichTextBox fileContentPreviewRichTb;
        private OpenFileDialog fileDialog;
        private Label fileChosenLabel;
        private Label label1;
        private Label label2;
        private Label optionsLabel;
        private Label label3;
        private Label dateLengthLabel;
        private TrackBar dateLengthTrackBar;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox saveAsFromatCombox;
        private Label label7;
        private TextBox resultFileNameTextBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Replacement;
        private Label label8;
        private Button button1;
        private ProgressBar progressBar1;
        private Label totalMessagesLabel;
        private Label totalWordsLabel;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TotalMessages;
        private DataGridViewTextBoxColumn TotalWords;
    }
}
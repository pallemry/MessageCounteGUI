using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageInformation.Extension
{
    public static class ControlExtensions
    {
        public static void SyncXAxis(this Control control, Control syncControl)
        {
            control.Location = control.Location with { X = syncControl.Location.X + (syncControl.Width - control.Width) };
        }
    }
}

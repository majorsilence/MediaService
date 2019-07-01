using Majorsilence.MediaService.Client.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Majorsilence.MediaService.Client.WinGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Downloads.Instance.UserName = WinGui.Properties.Settings.Default.UserName;
            Downloads.Instance.Password = Base64.DecodeFrom64(WinGui.Properties.Settings.Default.Password);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}

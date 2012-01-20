using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaServiceClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LibMediaServiceCommon.Downloads.Instance.UserName = MediaServiceClient.Properties.Settings.Default.UserName;
            LibMediaServiceCommon.Downloads.Instance.Password = LibMediaServiceCommon.Base64.DecodeFrom64(MediaServiceClient.Properties.Settings.Default.Password);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Majorsilence.MediaService.AdminTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LibProject2Database.Startup start = new LibProject2Database.Startup();
            //start.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainAdminForm());
        }
    }
}

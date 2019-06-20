using System;
using System.Collections.Generic;
using System.Text;

namespace Majorsilence.MediaService.Client.Common
{
    public class DataDirectory
    {

        public static string MajorSilenceLocalAppDataDirectory
        {
            get
            {
                string msDir = null;
                msDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                msDir = System.IO.Path.Combine(msDir, "MajorSilence");

                if (System.IO.Directory.Exists(msDir) == false)
                {
                    System.IO.Directory.CreateDirectory(msDir);
                }

                return msDir;
            }
        }

        public static string MajorSilenceMediaServiceLocalAppDataDirectory
        {
            get { 
                string dir = System.IO.Path.Combine(MajorSilenceLocalAppDataDirectory, "MediaService");

                if (System.IO.Directory.Exists(dir) == false)
                {
                    System.IO.Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }


    }
}

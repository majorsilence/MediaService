using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Majorsilence.MediaService.AdminTool
{
    public class Ffmpeg
    {


        public bool Convert(string filenameIn, string fileNameOut, int videoBitrateKilobits, int audioBitrateKilobits, string size)
        {
            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                p.StartInfo.FileName = "ffmpeg.exe";
                p.StartInfo.Arguments = string.Format("-i \"{0}\" -s {1} -vb {2}k -ab {3}k -threads 4 \"{4}\"", filenameIn, size, videoBitrateKilobits, audioBitrateKilobits, fileNameOut);

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.ErrorDialog = false;
                p.OutputDataReceived += HandleMediaPlayerOutputDataReceived;
                p.ErrorDataReceived += HandleMediaPlayerErrorDataReceived;

                p.Start();

                p.WaitForExit();
            }
            return false;
        }



        private void HandleMediaPlayerOutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string line = e.Data.ToString();
                System.Console.WriteLine(line);
            }
        }


        private void HandleMediaPlayerErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                System.Console.WriteLine(e.Data.ToString());
            }
        }
    }
}

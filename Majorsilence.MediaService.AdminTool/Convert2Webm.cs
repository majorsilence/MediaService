using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Majorsilence.MediaService.AdminTool
{

    /// <summary>
    /// Quickly convert videos to multiple webm video qualities.
    /// </summary>
    public partial class Convert2Webm : Form
    {
        public Convert2Webm()
        {
            InitializeComponent();
        }

        private void btnSelectVideo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                foreach (string filename in openFileDialog1.FileNames)

                lstFilePaths.Items.Add(filename);
            }
            else
            {
                return;
            }

        }

        private void lstFilePaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilePaths.SelectedIndex == -1)
            {
                return;
            }


            try
            {
                LibMPlayerCommon.Discover videoValues = new LibMPlayerCommon.Discover(lstFilePaths.SelectedItem.ToString().Trim());
                txtVideoBitrateOriginal.Text = videoValues.VideoBitrate.ToString();
                txtVidesAudioBitrateOriginal.Text = videoValues.AudioBitrate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            btnSelectVideo.Enabled = false;
            lstFilePaths.Enabled = false;
           
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;

            backgroundWorker1.RunWorkerAsync();
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int itemCount = 0; itemCount < lstFilePaths.Items.Count; itemCount++)
            { // each filepath
                string filePath = lstFilePaths.Items[itemCount].ToString().Trim();

                foreach (Control ctrl in groupBox1.Controls)
                { // each bitrate
                    if (ctrl is CheckBox)
                    {
                        CheckBox c = (CheckBox)ctrl;

                        if (c.Checked)
                        {
                            string outputName = System.IO.Path.GetFileNameWithoutExtension(filePath) + "-";
                            outputName += (DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Now.Day.ToString().PadLeft(2, '0'));
                            outputName += "-" + ctrl.Text + "kbps-hd720.webm";

                            backgroundWorker1.ReportProgress(1, "Converting: " + outputName);

                            if (System.IO.File.Exists(outputName))
                            {
                                System.IO.File.Delete(outputName);
                            }


                            // set proper audio bitrate so conversion does not fail.
                            // Eg. 8 kb/s will fail if converted to anythin over 64 kb/s.
                            int audioBitrate = AudioBitrateToUse(filePath);
                            bool allowSelectedVideoBitrate = AllowVideoBitrate(filePath, int.Parse(ctrl.Text));

                            if (allowSelectedVideoBitrate)
                            {
                                Ffmpeg boo = new Ffmpeg();
                                boo.Convert(filePath, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filePath),outputName), 
                                    int.Parse(ctrl.Text), audioBitrate, "hd720");
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Only allow certain conversion.  No point converting a 200 kb/s video to 5000 kb/s.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="requestBirate"></param>
        /// <returns></returns>
        private bool AllowVideoBitrate(string filePath, int requestBirate)
        {
            LibMPlayerCommon.Discover videoValues = new LibMPlayerCommon.Discover(filePath);
            int videoBitrate = videoValues.VideoBitrate;

            if (( requestBirate >=5000) && videoBitrate < 3000 )
            {   // No point upconverting this much.
                return false;
            }
            else if ((requestBirate >= 3000) && videoBitrate < 1000)
            {   // No point upconverting this much.
                return false;
            }
            else if ((requestBirate >= 1000) && videoBitrate < 200)
            {   // No point upconverting this much.
                return false;
            }

            return true;
        }


        /// <summary>
        /// Which bitrate should be used with the video.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private int AudioBitrateToUse(string filePath)
        {
            LibMPlayerCommon.Discover videoValues = new LibMPlayerCommon.Discover(filePath);
            int audioBitrate = videoValues.AudioBitrate;
            if (audioBitrate <= 64)
            {
                audioBitrate = 64;
            }
            else if (audioBitrate <= 128)
            {
                audioBitrate = 128;
            }
            else if (audioBitrate <= 196)
            {
                audioBitrate = 196;
            }
            else
            {
                audioBitrate = 256;
            }

            return audioBitrate;
        }




        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage == 1)
                {
                    toolStripStatusLabel1.GetType().InvokeMember("Text", System.Reflection.BindingFlags.SetProperty, null, toolStripStatusLabel1, new object[] { e.UserState.ToString() });
                }
            }
            catch (Exception ex)
            {
                //LibProject2Common.Logging.Instance.WriteLine(ex);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnConvert.Enabled = true;
            btnSelectVideo.Enabled = true;
            lstFilePaths.Enabled = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        }

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstFilePaths.SelectedIndex == -1)
                {
                    return;
                }
                lstFilePaths.Items.RemoveAt(lstFilePaths.SelectedIndex);
            }
            catch (Exception ex)
            {
                //LibProject2Common.Logging.Instance.WriteLine(ex);
                MessageBox.Show("Error removing Video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

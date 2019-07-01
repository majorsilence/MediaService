using Majorsilence.MediaService.Client.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Majorsilence.MediaService.Client.WinGui
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            mplayerPath.Text = WinGui.Properties.Settings.Default.MPlayerPath;

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            SetDownloadInfo();
        }

        private void SetDownloadInfo()
        {
            Downloads.Instance.ServiceAddress = textBaseAddress.Text;
            Downloads.Instance.UserName = textUserName.Text;
            Downloads.Instance.Password = textPassword.Text;
           


        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {

            try
            {
                MediaPlayer.Player p = new MediaPlayer.Player("http://files.majorsilence.com/mediaservice/video/big_buck_bunny_480p.webm", true, false, true);
                p.Show();
            }
            catch (Exception ex)
            {
                Logging.Instance.WriteLine(ex);
            }
        }

        private void btnCarousel_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm m = new MainForm();
                m.Show();
            }
            catch (Exception ex)
            {
                Logging.Instance.WriteLine(ex);
            }
        }


        private void userSetup_Click(object sender, EventArgs e)
        {
            try
            {
                UserSetup m = new UserSetup();
                m.Show();
            }
            catch (Exception ex)
            {
                Logging.Instance.WriteLine(ex);
            }
        }

        private void SaveMPlayerPath_Click(object sender, EventArgs e)
        {
            WinGui.Properties.Settings.Default.MPlayerPath = mplayerPath.Text.Trim();
            WinGui.Properties.Settings.Default.Save();
        }

        private void buttonSetDownload_Click(object sender, EventArgs e)
        {
            SetDownloadInfo();
        }


    }
}

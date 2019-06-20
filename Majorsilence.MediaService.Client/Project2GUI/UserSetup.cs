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
    public partial class UserSetup : Form
    {
        public UserSetup()
        {
            InitializeComponent();

            txtUserName.Text = WinGui.Properties.Settings.Default.UserName;
            txtPassword.Text = Base64.DecodeFrom64(WinGui.Properties.Settings.Default.Password);
        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.majorsilence.com/");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            WinGui.Properties.Settings.Default.UserName = txtUserName.Text.Trim();
            WinGui.Properties.Settings.Default.Password = Base64.EncodeTo64(txtPassword.Text);
            WinGui.Properties.Settings.Default.Save();

            Downloads.Instance.UserName = txtUserName.Text;
            Downloads.Instance.Password = txtPassword.Text.Trim();
        }
    }
}

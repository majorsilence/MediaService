using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaServiceClient
{
    public partial class UserSetup : Form
    {
        public UserSetup()
        {
            InitializeComponent();

            txtUserName.Text = MediaServiceClient.Properties.Settings.Default.UserName;
            txtPassword.Text = LibMediaServiceCommon.Base64.DecodeFrom64(MediaServiceClient.Properties.Settings.Default.Password);
        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.majorsilence.com/");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            MediaServiceClient.Properties.Settings.Default.UserName = txtUserName.Text.Trim();
            MediaServiceClient.Properties.Settings.Default.Password = LibMediaServiceCommon.Base64.EncodeTo64(txtPassword.Text);
            MediaServiceClient.Properties.Settings.Default.Save();

            LibMediaServiceCommon.Downloads.Instance.UserName = txtUserName.Text;
            LibMediaServiceCommon.Downloads.Instance.Password = txtPassword.Text.Trim();
        }
    }
}

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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void btnMediaInfo_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            try
            {
                MediaInfo dlg = new MediaInfo();
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                LibProject2Common.Logging.Instance.WriteLine(ex);   
            }

            this.Show();
             */
        }

        private void btnConvert2WebM_Click(object sender, EventArgs e)
        {

            this.Hide();

            try
            {
                Convert2Webm dlg = new Convert2Webm();
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                //LibProject2Common.Logging.Instance.WriteLine(ex);
            }

            this.Show();

        }

        private void btnMotionPictureRatings_Click(object sender, EventArgs e)
        {

        }
    }
}

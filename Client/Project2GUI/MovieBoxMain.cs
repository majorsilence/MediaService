using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2GUI
{
    public partial class MovieBoxMain : Form
    {

        private const int ImageWidth = 100;
        private const int ImageTop = 20;
        private const int ImageSeperationSize = 10;


        public MovieBoxMain()
        {
            InitializeComponent();
        }

        private void MovieBoxMain_Load(object sender, EventArgs e)
        {
            try
            {

                this.AddBox("Invalid Category");
                this.AddBox("AnotherInvalidCategory");
                this.AddBox("AnotherInvalidCategory");
                this.AddBox("AnotherInvalidCategory");
                this.AddBox("AnotherInvalidCategory");
                this.AddBox("AnotherInvalidCategory");
            }
            catch (Exception ex)
            {
                LibProject2Common.Logging.Instance.WriteLine(ex);
            }
        }


        private void AddBox(string category)
        {

            FlowLayoutPanel newPanel = new FlowLayoutPanel();
            newPanel.FlowDirection = FlowDirection.LeftToRight;
            //newPanel.Width = mainPanel.Width;
            newPanel.AutoSize = true;
           // newPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.mainPanel.Controls.Add(newPanel);

            //SearchMedia search = new SearchMedia();

            //// For now to test return the search (max out at 20).
            //DataTable searchResults = search.Search(category);

            //foreach (DataRow movie in searchResults.Rows)
            //{
            //    string movieOneName = movie["MediaName"].ToString().Trim();
            //    string movieOneStoryLine = movie["StoryLine"].ToString().Trim();
            //    long mediaId = long.Parse(movie["IdMediaInfo"].ToString());

            //    // ***********************

            //    string imageLocation = movie["CoverArtLocation"].ToString().Trim();
            //    Image movieImage;
            //    if (imageLocation == "UNKNOWN")
            //    {
            //        movieImage = (Image)Project2GUI.Properties.Resources.no_image;
            //    }
            //    else
            //    {
            //        movieImage = LibProject2Common.Downloads.Instance.WebImage(imageLocation);
            //    }

            //    this.AddBoxItem(ref newPanel, movieImage, movieOneStoryLine, movieOneName, mediaId);

            //}


            // For testing.  Should be removed from live code.
            for (int i = 0; i < 10; i++)
            {

                this.AddBoxItem(ref newPanel, (Image)Project2GUI.Properties.Resources.no_image, "A weird haired tux picture", "Tux " + i.ToString(), -1);
            }
        }

        private void AddBoxItem(ref FlowLayoutPanel workingPanel,  Image img, string summary, string name, long mediaInfoId)
        {


            CarouselItems ctrl = new CarouselItems();
            ctrl.Image = img;
            ctrl.Width = MovieBoxMain.ImageWidth;
            ctrl.Height = MovieBoxMain.ImageWidth;

            ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

            VideoInfo v = new VideoInfo(name, summary, mediaInfoId);
            ctrl.Tag = v;


            ctrl.MouseHover += new EventHandler(ctrl_MouseHover);
            ctrl.MouseLeave += new EventHandler(ctrl_MouseLeave);
            ctrl.Click += new EventHandler(ctrl_Click);

            workingPanel.Controls.Add(ctrl);
        }


        /// <summary>
        /// When an item is clicked attempt to play the video.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrl_Click(object sender, EventArgs e)
        {
            if ((Control)sender is CarouselItems)
            {

                this.Hide();

                try
                {


                    CarouselItems b = (CarouselItems)sender;
                    VideoInfo v = (VideoInfo)b.Tag;
                    SearchMedia search = new SearchMedia();

                    if (v.MediaInfoId == -1)
                    {
                        throw new Exception("No media files to search for.  MediaId is set to -1.");
                    }

                    string url = search.Search(v.MediaInfoId);
                    Player dlg = new Player(url, true, true);
                    dlg.ShowDialog();
                }
                catch (Exception ex)
                {
                    LibProject2Common.Logging.Instance.WriteLine(ex);
                }
                this.Show();
            }
        }



        /// <summary>
        /// When hovering over a video show preview information about it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrl_MouseHover(object sender, EventArgs e)
        {
            if ((Control)sender is CarouselItems)
            {
                CarouselItems b = (CarouselItems)sender;
                VideoInfo v = (VideoInfo)b.Tag;
                txtMovieInfo.Text = string.Format("Video Name: {0}{1}{1}Summary: {2}", v.Name, System.Environment.NewLine, v.Summary);
                txtMovieInfo.Visible = true;
            }
        }

        /// <summary>
        /// Once moved off no longer show preview info on the video.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrl_MouseLeave(object sender, EventArgs e)
        {
            txtMovieInfo.Visible = false;
            txtMovieInfo.Text = "";
        }


    }
}

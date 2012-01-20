using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace MediaServiceClient
{
    public partial class MainForm : Form
    {
        private VerticalList carouselLayoutPanel;
        private int rowCount = 0;


        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            carouselLayoutPanel = new VerticalList();

            carouselLayoutPanel.Dock = DockStyle.Fill;
            this.Controls.Add(carouselLayoutPanel);

            AddCarousel("TEST");
            //AddCarousel("TEST");
            //AddCarousel("TEST");
            //AddCarousel("TEST");
            //AddCarousel("TEST");
            //AddCarousel("TEST");
            //AddCarousel("TEST");
            AddCarousel(""); // first 20 found
            AddCarousel("Biology");
            AddCarousel("Action");
            AddCarousel("Family");
            AddCarousel("Fantasy");
            AddCarousel("War");
            AddCarousel("Thriller");


        }




        private void AddCarousel(string category)
        {

            Carousel carousel1 = new Carousel(category);
            try
            {
                carousel1.Width = carouselLayoutPanel.Width;
                carousel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                if (category == "TEST")
                {
                    for (int i = 0; i < 20; i++)
                    {
                        carousel1.Add(MediaServiceClient.Properties.Resources.no_image, "Test", "Test", -1);


                    }

                    carouselLayoutPanel.AddCarousel(carousel1);

                   // carousel1.Height = carousel1.Height;
                   // carouselLayoutPanel.AddCarousel(carousel1);
                   
                    rowCount++;

                    return;
                }


                LibMediaServiceCommon.SearchMedia search = new LibMediaServiceCommon.SearchMedia();
				
                // For now to test return the search (max out at 20).
                List<LibMediaServiceCommon.DTO.MediaInfo> searchResults = search.Search("", category);



                foreach (LibMediaServiceCommon.DTO.MediaInfo movie in searchResults)
				{
					string movieOneName = movie.MediaName;
                    string movieOneStoryLine = movie.StoryLine.Trim();
                    long mediaId = movie.IdMediaInfo;
					
					// ***********************

                    string imageLocation = movie.CoverArtLocation.Trim();

                    carousel1.Add(imageLocation, movieOneStoryLine, movieOneName, mediaId);
		            
				}

                carouselLayoutPanel.AddCarousel(carousel1);
                
			}
			catch(Exception ex)
			{
				LibMediaServiceCommon.Logging.Instance.WriteLine(ex);
			}
            
        }


        protected override bool ProcessKeyPreview(ref System.Windows.Forms.Message m)
        {
            switch (m.WParam.ToInt32())
            {
                // TODO: Fix so move commands are sent to correct carousel
                case (int)Keys.Right:
                    //this.carousel1.MoveItem(Carousel.Direction.LEFT);
                    break;
                case (int)Keys.Left: // <--- left arrow.
                    //this.carousel1.MoveItem(Carousel.Direction.RIGHT);
                    // do stuff for Left Arrow here.
                    break;
                case (int)Keys.Up: // <--- up arrow.
                    Console.Write("you pressed the up arrow!\n");
                    // do stuff for Up Arrow here.
                    break;
                case (int)Keys.Down: // <--- down arrow.
                    Console.Write("you pressed the down arrow!\n");
                    // do stuff for Down Arrow here.
                    break;
            }
            return false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}

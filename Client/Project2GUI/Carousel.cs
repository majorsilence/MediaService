using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaServiceClient
{
    public partial class Carousel : UserControl
    {

        private List<CarouselItems> _controls;
        
        public const int ImageWidth = 100;
        public const int ImageTop = 20;
        private const int ImageSeperationSize = 10;
        private const int StartingPositionX = 0;
        public const int MoveSize = 2;

        public Carousel() 
        {
            InitializeComponent();
        }

        public Carousel(string category)
        {
            InitializeComponent();

            this._controls = new List<CarouselItems>();
            lblCategory.Text = category;
        }


        public enum Direction
        {
            RIGHT,
            LEFT
        }

        // Used do place a carousel on a parent control.
        private int _x;
        private int _y;
        public int HiddenX
        {
            get { return _x; }
            set { _x = value; }
        }

        public int HiddenY
        {
            get { return _y; }
            set { _y = value; }
        }


        private void Carousel_Load(object sender, EventArgs e)
        {

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.RIGHT);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.LEFT);
        }

        /// <summary>
        /// Load a category of videos into this carousel.
        /// Everything calling the webservice and downloading of coverart is run in a background thread.
        /// </summary>
        /// <param name="category"></param>
        public void Add(string category)
        {
            AsyncMethodCaller caller = new AsyncMethodCaller(InternalAdd);
            IAsyncResult result = caller.BeginInvoke(category, null, null);
        }

        private delegate void AsyncMethodCaller(string value);
        private void InternalAdd(string category)
        {
            // Running on background thread

            if (category == "TEST")
            {
                for (int i = 0; i < 20; i++)
                {
                    this.BeginInvoke(new Action<Image, string, string, long>(InternalAdd), 
                        MediaServiceClient.Properties.Resources.no_image, "Test", "Test", -1);
                }

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

                string imageLocation = LibMediaServiceCommon.Downloads.Instance.MediaAddress + "/" + movie.CoverArtLocation.Trim();

                this.BeginInvoke(new Action<string, string, string, long>(InternalAdd),
                    imageLocation, movieOneStoryLine, movieOneName, mediaId);

            }

        }

        private void InternalAdd(string imgUrl, string summary, string name, long mediaInfoId)
        {
            // Running on background thread

            Image cacheImg = LibMediaServiceCommon.LocalCache.GetCachedImage(mediaInfoId);
            if (imgUrl.ToLower() == "unknown")
            {
                cacheImg = MediaServiceClient.Properties.Resources.no_image;
            }

           

            if (cacheImg == null)
            {
                cacheImg = LibMediaServiceCommon.Downloads.Instance.WebImage(imgUrl);
                if (cacheImg == null)
                {
                    cacheImg = MediaServiceClient.Properties.Resources.no_image;
                }
                else
                {

                    LibMediaServiceCommon.LocalCache.SaveCacheImage(cacheImg, mediaInfoId);
                }

                this.BeginInvoke(new Action<Image, string, string, long>(InternalAdd),
                    cacheImg, summary, name, mediaInfoId);
            }
            else
            {
                this.BeginInvoke(new Action<Image, string, string, long>(InternalAdd),
                    cacheImg, summary, name, mediaInfoId);
            }

        }       

        /// <summary>
        /// Add a new control to the carousel.
        /// </summary>
        /// <param name="img"></param>
        /// <param name="summary"></param>
        /// <param name="name"></param>
        private void InternalAdd(Image img, string summary, string name, long mediaInfoId)
        {
            // running on gui thread
            CarouselItems ctrl = new CarouselItems();
            ctrl.Image = img;
            ctrl.Width = Carousel.ImageWidth;
            ctrl.Height = Carousel.ImageWidth;

            ctrl.SizeMode = PictureBoxSizeMode.StretchImage;

            VideoInfo v = new VideoInfo(name, summary, mediaInfoId);

            ctrl.Tag = v;

            if (this._controls.Count == 0)
            {
                ctrl.HiddenX = StartingPositionX; // just enough space so it is not under the LEFT button
                ctrl.HiddenY = Carousel.ImageTop;           
            }
            else
            {
                ctrl.HiddenY = Carousel.ImageTop;
                ctrl.HiddenX = this._controls[this._controls.Count - 1].HiddenX;
                ctrl.HiddenX += (Carousel.ImageWidth + Carousel.ImageSeperationSize);
            }

            ctrl.Location = new System.Drawing.Point(ctrl.HiddenX, ctrl.HiddenY);

            ctrl.MouseHover += new EventHandler(ctrl_MouseHover);
            ctrl.MouseLeave += new EventHandler(ctrl_MouseLeave);
            ctrl.Click += new EventHandler(ctrl_Click);

            this._controls.Add(ctrl);
            this.panelItems.Controls.Add(ctrl);
           

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

                this.Parent.Hide();

                try
                {
                    

                    CarouselItems b = (CarouselItems)sender;
                    VideoInfo v = (VideoInfo)b.Tag;
                    LibMediaServiceCommon.SearchMedia search = new LibMediaServiceCommon.SearchMedia();

                    if (v.MediaInfoId == -1)
                    {
                        throw new Exception("No media files to search for.  MediaId is set to -1.");
                    }

                    string url = LibMediaServiceCommon.Downloads.Instance.MediaAddress + "/" + search.Search(v.MediaInfoId);
                    MediaPlayer.Player dlg = new MediaPlayer.Player(url, true, true, true);
                    dlg.ShowDialog();
                }
                catch (Exception ex)
                {
                    LibMediaServiceCommon.Logging.Instance.WriteLine(ex);
                }
                this.Parent.Show();
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
                textBox1.Text = string.Format("Video Name: {0}{1}{1}Summary: {2}", v.Name, System.Environment.NewLine, v.Summary);
                textBox1.Visible = true;
            }
        }

        /// <summary>
        /// Once moved off no longer show preview info on the video.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrl_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
        }


        /// <summary>
        /// Move the carosule items.
        /// </summary>
        /// <param name="dir">Left or Right.</param>
        public void MoveItem(Direction dir)
        {

            for (int i = 0; i < (ImageWidth/Carousel.MoveSize); i++)
            {

                this._MoveItemsHiddenXValues(dir);
            }


            _wrapAround();

        }


        private bool NeedToResetPostionsToDefault()
        {
            if (this._controls[0].HiddenX >= panelItems.Right || (this._controls[this._controls.Count - 1].HiddenX - Carousel.ImageWidth <= 0))
            {
                return true;
            }
            return false;
        }

        private void _wrapAround()
        {
            // Check if left side is to far right or
            // if right images have gone off left.
            // if this is true then nothing is on the screen.
            // Move items to non hidden values if they are visible.
            if (NeedToResetPostionsToDefault())
            {
                for (int i = 0; i < this._controls.Count; i++)
                {
                    if (i == 0)
                    {
                        // It is the very first item
                        this._controls[i].HiddenX = StartingPositionX;
                    }
                    else
                    {
                        this._controls[i].HiddenX = (this._controls[i - 1].HiddenX + Carousel.ImageWidth) + Carousel.ImageSeperationSize;
                    }

                    if (this._controls[i].HiddenX >= 0 && ((this._controls[i].HiddenX + Carousel.ImageWidth) <= this.panelItems.Right))
                    {
                        this._controls[i].Left = this._controls[i].HiddenX;
                    }
                    Application.DoEvents();
                }
            }

        }


        /// <summary>
        /// Move the carousel items HiddenX values left or right.  Very inefficent but workable for now.
        /// </summary>
        /// <param name="dir"></param>
        private void _MoveItemsHiddenXValues(Direction dir)
        {
            foreach (Control ctrl in this.panelItems.Controls)
            {

                if (ctrl is CarouselItems)
                {
                    CarouselItems cItem = (CarouselItems)ctrl;

                    
                    if (dir == Direction.RIGHT)
                    {
                        // Move the items to the right.
                        cItem.HiddenX += Carousel.MoveSize;

                        if (cItem.Left <= panelItems.Width)
                        {
                            cItem.Left = cItem.HiddenX;
                        }

                    }
                    else
                    {
                        // Move the items to the left.
                        cItem.HiddenX  -= Carousel.MoveSize;

                        if (cItem.Right >= 0)
                        {
                            cItem.Left = cItem.HiddenX;
                        }
                    }


                    Application.DoEvents();
                }
            }

        }

    }
}

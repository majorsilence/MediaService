using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaServiceClient
{
    class CarouselItems : PictureBox
    {

        private int _x;
        private int _y;

        public CarouselItems() : base()
        {
        }

        public int HiddenX
        {
            get { return _x; }
            set { _x = value;}
        }

        public int HiddenY
        {
            get { return _y; }
            set { _y = value; }
        }

    }

}

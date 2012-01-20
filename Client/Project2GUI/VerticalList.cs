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
    public partial class VerticalList : UserControl
    {
        private List<Carousel> _controls;

        private const int CarosuelSeperationSize = 10;
        private const int StartingPositionY = 20;
        private const int MoveSize = 40;

        public VerticalList()
        {
            InitializeComponent();

            this._controls = new List<Carousel>();

        }

        private void VerticalList_Load(object sender, EventArgs e)
        {

        }

        public enum Direction
        {
            UP,
            DOWN
        }


        private bool NeedToResetPostionsToDefault()
        {
            if (this._controls[0].Top >= this.panel1.Height || ((this._controls[this._controls.Count - 1].Top + this._controls[0].Height) - VerticalList.CarosuelSeperationSize <= 0))
            {
                return true;
            }
            return false;
        }

        private void SetDefaultPositions()
        {
            int i = 0;
            Carousel previous = new Carousel();
            foreach (Control ctrl in this.panel1.Controls)
            {

                if (ctrl is Carousel)
                {

                    ctrl.Left = 0;

                    if (i == 0)
                    {
                        ctrl.Top = StartingPositionY; // just enough space so it is not under the LEFT button  
                    }
                    else
                    {
                        int value = previous.Top;
                        ctrl.Top = (previous.Height + VerticalList.CarosuelSeperationSize) + value;
                    }
                    previous = (Carousel)ctrl;
                    i++;
                }
            }
        }


        public void AddCarousel(Carousel ctrl)
        {
            ctrl.Width = this.Width;

            ctrl.Left = 0;

            if (this._controls.Count == 0)
            {
                ctrl.Top = StartingPositionY; // just enough space so it is not under the LEFT button
            }
            else
            {
                 int value = this._controls[this._controls.Count - 1].Top;
                ctrl.Top = (ctrl.Height + VerticalList.CarosuelSeperationSize) + value;
            }

            //ctrl.Location = new System.Drawing.Point(ctrl.HiddenX, ctrl.HiddenY);


            this._controls.Add(ctrl);
            this.panel1.Controls.Add(ctrl);
            
        }


        private void _Move(Direction dir)
        {
             //this.panel1.Top = -this.vScrollBar1.Value;

            if (NeedToResetPostionsToDefault())
            {        
                SetDefaultPositions();
            }

            foreach (Control ctrl in this.panel1.Controls)
            {

                if (ctrl is Carousel)
                {
                    Carousel cItem = (Carousel)ctrl;

                    if (dir == Direction.DOWN)
                    {
                        cItem.Top = cItem.Top - VerticalList.MoveSize;
                    }
                    else
                    {
                        cItem.Top = cItem.Top + VerticalList.MoveSize;
                    }
                }

            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            // The top moveup moves items down.
           //MoveItem(Direction.DOWN);
            _Move(Direction.UP);
            
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            // the bottom moves items up the list

            _Move(Direction.DOWN);
           
        }

      
    }
}

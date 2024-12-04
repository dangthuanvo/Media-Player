using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;

namespace CustomControl
{
    public class PictureBoxCustom : PictureBox
    {
        public static Point g_;
        public PictureBoxCustom(IContainer c)
        {
            c.Add(this);
        }

        Point point;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Bottom < 50 || this.Right < 50 || Global.sizePanelPictureBox.Width - this.Left < 50 || Global.sizePanelPictureBox.Height - this.Top < 50)
                {
                    return;
                }
                this.Top += e.Y - point.Y;
                this.Left += e.X - point.X;
                if (this.Bottom < 50)
                {
                    this.Top = -this.Size.Height + 50;
                }
                if (this.Right < 50)
                {
                    this.Left = -this.Size.Width + 50;
                }
                if (Global.sizePanelPictureBox.Width - this.Left < 50)
                {
                    this.Left = Global.sizePanelPictureBox.Width - 50;
                }
                if (Global.sizePanelPictureBox.Height - this.Top < 50)
                {
                    this.Top = Global.sizePanelPictureBox.Height - 50;
                }
                //this.Container\\\\
            }
            g_.X = this.Left;
            g_.Y = this.Top;
            //Console.WriteLine(this.Left.ToString() + " " + this.Right.ToString());
            base.OnMouseMove(e);
        }
        int mid = 0;
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control || true)
            {
                if (e.Delta > 0)
                {
                    if (this.Width > 10000 || this.Height > 10000)
                    {

                    }
                    else
                    {
                        mid++;
                        int preWid = this.Width;
                        int preHei = this.Height;
                        int tempWid = (int)(this.Width * 1.1);
                        int tempHei = (int)(this.Height * 1.1);
                        this.Width = tempWid;
                        this.Height = tempHei;
                        this.Location = new Point(this.Location.X - (tempWid - preWid) / 2, this.Location.Y - (tempHei - preHei) / 2);
                    }
                }
                else
                {
                    if (this.Width < 60 || this.Height < 60)
                    { }
                    else
                    {
                        mid--;
                        int preWid = this.Width;
                        int preHei = this.Height;
                        int tempWid = (int)(this.Width * 0.9);
                        int tempHei = (int)(this.Height * 0.9);
                        this.Width = tempWid;
                        this.Height = tempHei;
                        this.Location = new Point(this.Location.X + (preWid - tempWid) / 2, this.Location.Y + (preHei - tempHei) / 2);
                        if (this.Bottom < 50)
                        {
                            this.Top = -this.Size.Height + 50;

                        }
                        if (this.Right < 50)
                        {
                            this.Left = -this.Size.Width + 50;
                        }
                    }

                }
                if (mid == 0)
                {
                    this.Size = Global.dfSize;
                    this.Location = new Point((Global.sizePanelPictureBox.Width - Global.dfSize.Width) / 2, (Global.sizePanelPictureBox.Height - Global.dfSize.Height) / 2);
                }
                    base.OnMouseWheel(e);
            }
        }
    }
}

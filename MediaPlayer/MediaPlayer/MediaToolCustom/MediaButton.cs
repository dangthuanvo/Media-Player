using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using Bunifu.UI.WinForms;
using MediaPlayer.Properties;


namespace MediaToolCustom
{
    public class MediaButton : Button
    {
        public int[] pos { get; set; }
        public ButtonFavEra fav;
        public ButtonFavEra era;
        public MediaButton()
        { }
        public MediaButton(int idx, Size size) //không kèm 2 button Fav và Era
        {

            pos = new int[1] { idx };
            this.AutoSize = false;
            this.Size = size;
            this.BackColor = Color.Indigo;
            this.Dock = DockStyle.None;
        
            this.MouseEnter += delegate (object sender, EventArgs e)
            {
                this.SetBounds(this.Left - 8, this.Top - 4, this.Width + 16, this.Height + 8);
            };
            this.MouseLeave += delegate (object sender, EventArgs e)
            {
                this.SetBounds(this.Left + 8, this.Top + 4, this.Width - 16, this.Height - 8);
            };
        }
        public MediaButton(int idx)
        {

            pos = new int[1] { idx };
            this.AutoSize = false;
            this.Size = new Size(290, 180);
            this.BackColor = Color.Indigo;
            this.Dock = DockStyle.None;
            //---------------------------
            fav = new ButtonFavEra();
            fav.pos = this.pos;
            fav.Image = Resources.preheart2;
            fav.Location = new Point(0, 0);
            //----------------------------
            era = new ButtonFavEra();
            era.pos = this.pos;
            era.Image = Resources.bin2;
            era.Location = new Point(this.Size.Width - era.Size.Width, 0);
            this.Controls.Add(fav);
            this.Controls.Add(era);
            this.MouseEnter += delegate (object sender, EventArgs e)
            {
                this.SetBounds(this.Left - 8, this.Top - 4, this.Width + 16, this.Height + 8);
                this.era.Location = new Point(this.Size.Width - era.Size.Width, 0);
            };
            this.MouseLeave += delegate (object sender, EventArgs e)
            {
                this.SetBounds(this.Left + 8, this.Top + 4, this.Width - 16, this.Height - 8);
                this.era.Location = new Point(this.Size.Width - era.Size.Width, 0);
            };
        }

        public void DisposeButton()
        {
            if (era != null)
            {
                era.Dispose();
            }
            if (fav != null)
            {
                fav.Dispose();
            }
            this.Dispose();
        }
    }
}

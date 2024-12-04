using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaToolCustom
{
    public class NonFlickerPannel : Panel
    {
        public NonFlickerPannel() 
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.OptimizedDoubleBuffer,
              true);
            //this.Dock = DockStyle.Fill;
        }
        public NonFlickerPannel(IContainer c) : base()
        {
            c.Add(this);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer,
                          true);
            this.DoubleBuffered = true;
        }
        //protected override void OnPaint(PaintEventArgs e) { }
    }
}

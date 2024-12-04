using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class fSplashScreen : Form
    {
        private int counterTimer1;
        public fSplashScreen()
        {
            InitializeComponent();
        }

        private void fSplashScreen_Load(object sender, EventArgs e)
        {
            string x = System.IO.Directory.GetCurrentDirectory();
            intro.uiMode = "None";
            intro.settings.setMode("loop", true);
            
            intro.URL = x + @"\intro.mp4";
            //MessageBox.Show(intro.URL);
            intro.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counterTimer1 >= 65)
            {
                timer1.Enabled = false;
                this.Close();
            }
            else
            {
                counterTimer1++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (!Global.isNonUser)
            {
                string rf = File.ReadAllText(Global.currenthistorypath);
                richTextBox1.Text = rf;
                button1.Text = "Your log - Press to change to global log";
            }
            else
            {
                string rf = File.ReadAllText(Global.historypath);
                richTextBox1.Text = rf;
                button1.Text = "Global log";
                button1.Enabled = false;
            }
        }
        public bool ismine = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ismine)
            {
                ismine = false;
                button1.Text = "Global log - Press to change to your log";
                string rf = File.ReadAllText(Global.historypath);
                richTextBox1.Text = rf;
            }
            else 
            {
                ismine = true;
                button1.Text = "Your log - Press to change to global log";
                string rf = File.ReadAllText(Global.currenthistorypath);
                richTextBox1.Text = rf;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Properties;
using System.Data.SqlClient;
using System.IO;
using MediaPlayerCore;
using System.Media;
using System.Security.Cryptography;
using System.Speech.Synthesis;
namespace MediaPlayer
{
    public partial class fMain : Form
    {
        ucYoutube ucYoutube1 = new ucYoutube();
        SoundPlayer a = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound1.wav");
        SoundPlayer b = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound2.wav");
        SoundPlayer c = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound3.wav");
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public fMain()
        {
            InitializeComponent();
            ucDefault1.BringToFront();
            Imvisible();
            Global.isMute = false;
            this.mainPanel.Controls.Add(this.ucYoutube1);
            ucYoutube1.Dock = DockStyle.Fill;
            if (Global.isNonUser)
            {
                Global.currentlastname = "Guest";
                Global.currentusername = "guest";
                logoutButton.Text = "LOG IN";
            }
            hellolb.Text = "Hello " + Global.currentlastname + ",";
            if (!Global.isNonUser)
            {
                ucMusic1.CreateButtonWithUserData();
                ucVideo1.CreateButtonWithUserData();
                ucPicture1.CreateButtonWithUserData();
            }
            SpeechSynthesizer synth = new SpeechSynthesizer();
        }

        private void Imvisible()
        {
            returnButton.Visible = false;
            progressBar.Visible = false;
        }
        private void Exit(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.Speak("See you again" + Global.currentlastname);
            if (!Global.isNonUser)
            {
                Global.UpdateDataUser();
            }
            UpdateSetting();
            Global.UpdateHistory(Global.currentusername, "đã đăng xuất!");
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void UpdateSetting()
        {
            using (StreamWriter writetext = new StreamWriter(Global.settingpath))
            {
                if (Global.isDark)
                    writetext.Write("1");
                else
                    writetext.Write("0");
                if (Global.haveIntro)
                    writetext.Write("1");
                else
                    writetext.Write("0");
            }
        }
        private const int cGrip = 16;   
        private const int cCaption = 32;

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    if (this.Width < 300 || this.Height < 200)
        //    {
        //        this.Width = 300;
        //        this.Height = 200;
        //    }
        //    base.WndProc(ref m);
        //}
        //====//
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
    //====//
    private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private static bool MAXIMIZED = false;
        private void Maximize(object sender, System.EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
                //ucHome1.Resize(ucHome1.Size);
                maxButton.Image = Resources.Expand;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
                //ucHome1.Resize(ucHome1.Size);
                maxButton.Image = Resources.Collaps;
                Global.sizePanelPictureBox = ucPicture1.Controls.Find("panelDisplay", true).OfType<Bunifu.UI.WinForms.BunifuPanel>().FirstOrDefault().Size;
            }
        }
        private void PausePlayingMedia()
        {
            if (ucVideo1.Controls.Find("playerVideo", true).OfType<AxWMPLib.AxWindowsMediaPlayer>().FirstOrDefault().playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ucVideo1.Controls.Find("playpauseButton", true).OfType<Guna.UI2.WinForms.Guna2ImageButton>().FirstOrDefault().PerformClick();
            }
            if (ucMusic1.Controls.Find("playerMusic", true).OfType<AxWMPLib.AxWindowsMediaPlayer>().FirstOrDefault().playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ucMusic1.Controls.Find("playpauseButton", true).OfType<Guna.UI2.WinForms.Guna2ImageButton>().FirstOrDefault().PerformClick();
            }
            ucYoutube1.StopAndBacktoDefault();
        }

        bool homeClicked = false;
        bool videoClicked = false;
        bool musicClicked = false;
        bool photoClicked = false;
        bool YoutubeClicked = false;
        private void allunClicked()
        {
            homeClicked = false;
            videoClicked = false;
            musicClicked = false;
            photoClicked = false;
            YoutubeClicked = false;
        }
        string tempText = "";
        public bool checkClicked()
        {
            if (!homeClicked && !videoClicked && !musicClicked && !photoClicked && !YoutubeClicked)
                return false;
            return true;
        }
        private void historyIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "History";
            if(!Global.isMute)
                b.Play();
        }
        private void historyOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }
        private void homeIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "Home";
            if (!Global.isMute)
                b.Play();
        }
        private void homeOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }

        private void videoIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "Video";
            if (!Global.isMute)
                b.Play();
        }

        private void videoOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }

        private void pictureIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "Photo";
            if (!Global.isMute)
                b.Play();
        }

        private void pictureOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }

        private void musicIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "Music";
            if (!Global.isMute)
                b.Play();
        }

        private void musicOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }
        private void YoutubeIn(object sender, EventArgs e)
        {
            ctrLB.BringToFront();
            ctrLB.Text = "Global";
            if (!Global.isMute)
                b.Play();
        }

        private void YoutubeOut(object sender, EventArgs e)
        {
            if (!checkClicked())
                ctrLB.SendToBack();
            else
                ctrLB.Text = tempText;
        }
        bool colorlabel = false;
        private void buttonAllOff()
        {
            homeButton.BackColor = Color.Indigo;
            pictureButton.BackColor = Color.Indigo;
            videoButton.BackColor = Color.Indigo;
            musicButton.BackColor = Color.Indigo;
            YoutubeButton.BackColor = Color.Indigo;
        }
        private void homeClick(object sender, EventArgs e)
        {
            if (!Global.isMute)
                a.Play();
            if (colorlabel)
                buttonAllOff();
            homeButton.BackColor = Color.DarkBlue;
            colorlabel = true;
            returnButton.Visible = true;
            processBar();
            ucHome1.BringToFront();
            ucHome1.BackgroundImage = Resources.The_Emerson_melbourne4; // LÀM ƠN ĐỪNG ĐỤNG CÁI NÀY <3
            ucHome1.Show();
            allunClicked();
            tempText = "Home";
            homeClicked = true;
            ucHome1.UpdateFav();
            PausePlayingMedia();
            ucVideo1.ucVideo_removeMess();
            ucMusic1.ucMusic_removeMess();
            
        }
        private void videoClick(object sender, EventArgs e)
        {
            if (!Global.isMute)
                a.Play();
            if (colorlabel)
                buttonAllOff();
            videoButton.BackColor = Color.DarkBlue;
            colorlabel = true;
            returnButton.Visible = true;
            processBar();
            ucVideo1.BringToFront();
            if (ucVideo1.GetCurrentTab() == 1)
                ucVideo1.ucVideo_getMess();
            ucVideo1.UpdateVideoFromYoutube();
            if(!Global.isDark)
                ucVideo1.BackColor = Color.White;
            else
                ucVideo1.BackColor = Color.Black;
            allunClicked();
            tempText = "Video";
            videoClicked = true;
            PausePlayingMedia();
            ucMusic1.ucMusic_removeMess();
        }

        private void pictureClick(object sender, EventArgs e)
        {
            if (!Global.isMute)
                a.Play();
            if (colorlabel)
                buttonAllOff();
            pictureButton.BackColor = Color.DarkBlue;
            colorlabel = true;
            returnButton.Visible = true;
            processBar();
            ucPicture1.BringToFront();
            if (!Global.isDark)
                ucPicture1.BackColor = Color.White;
            else
                ucPicture1.BackColor = Color.Black;
            allunClicked();
            tempText = "Photo";
            photoClicked = true;
            PausePlayingMedia();
            ucVideo1.ucVideo_removeMess();
            ucMusic1.ucMusic_removeMess();
        }

        private void musicClick(object sender, EventArgs e)
        {
            if (!Global.isMute)
                a.Play();
            if (colorlabel)
                buttonAllOff();
            musicButton.BackColor = Color.DarkBlue;
            colorlabel = true;
            returnButton.Visible = true;
            processBar();
            ucMusic1.BringToFront();
            if (ucMusic1.GetCurrentTab() == 1)
                ucMusic1.ucMusic_getMess();
            ucMusic1.UpdateAudioFromYoutube();
            if (!Global.isDark)
                ucMusic1.BackColor = Color.White;
            else
                ucMusic1.BackColor = Color.Black;
            allunClicked();
            tempText = "Music";
            musicClicked = true;
            PausePlayingMedia();
            ucVideo1.ucVideo_removeMess();
        }
        private void YoutubeButton_Click(object sender, EventArgs e)
        {
            if (!Global.isMute)
                a.Play();
            if (colorlabel)
                buttonAllOff();
            YoutubeButton.BackColor = Color.DarkBlue;
            colorlabel = true;
            returnButton.Visible = true;
            processBar();
            ucYoutube1.BringToFront();
            if (!Global.isDark)
                ucYoutube1.BackColor = Color.White;
            else
                ucYoutube1.BackColor = Color.Black;
            allunClicked();
            tempText = "Global";
            YoutubeClicked = true;
            PausePlayingMedia();
            ucVideo1.ucVideo_removeMess();
            ucMusic1.ucMusic_removeMess();
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            returnButton.Visible = true;
            processBar();
            PausePlayingMedia();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            returnButton.Visible = true;
            processBar();
            PausePlayingMedia();
        }
        private void returnButtonHome_Click(object sender, EventArgs e)
        {
            buttonAllOff();
            returnButton.Visible = false;
            processBar();
            ucDefault1.BringToFront();
            allunClicked();
            ctrLB.SendToBack();
            PausePlayingMedia();
            c.Play();
        }
        private void processBar()
        {
            progressBar.Value = 0;
            progressBar.Visible = true;
            progressBar.TransitionValue(100, 500);
            progressBar.Value = 0;
        }
        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            ucHome1._Resize(ucHome1.Size);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (!Global.isNonUser)
            {
                Global.UpdateDataUser();
            }
            UpdateSetting();
            Global.UpdateHistory(Global.currentusername, "đã đăng xuất!");
            this.DialogResult = DialogResult.Yes; //Đăng xuất, tắt app và mở process mới
            this.Close();
        }

        public void DfsDispose(Control u)
        {
            foreach (Control v in u.Controls)
                DfsDispose(v);
            u.Dispose();
        }

        private void settingButton_Click_1(object sender, EventArgs e)
        {
            using (Setting form = new Setting())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bool[] result = form.Result;
                    if (result[0])
                    {
                        ucMusic1.DeleteAllData();
                    }
                    if (result[1])
                    {
                        ucVideo1.DeleteAllData();
                    }
                    if (result[2])
                    {
                        ucPicture1.DeleteAllData();
                    }    
                }
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SetOutputToDefaultAudioDevice();
            //synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            //synth.Speak(hellolb.Text);
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.Speak(hellolb.Text);
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Global.isMute)
            {
                Global.isMute = false;
            }
            else
                Global.isMute = true;
        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            exitButton.PerformClick();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            using (History form = new History())
            {
                form.ShowDialog();
            }
        }
        List<string> DnDVideo = new List<string>();
        List<string> DnDMusic = new List<string>();
        List<string> DnDPicture = new List<string>();
        private void fMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string ex = file.Substring(file.LastIndexOf('.') + 1);
                if (ex == "mp4" || ex == "avi" || ex == "wmv" || ex == "flv")
                    DnDVideo.Add(file);
                if (ex == "mp3" || ex == "flac" || ex == "wav" ||                                                                               ex == "aac")
                    DnDMusic.Add(file);
                if (ex == "png" || ex == "jpg")
                    DnDPicture.Add(file);
            }
            if (DnDVideo.Count != 0)
                ucVideo1.CreateButtonWithDragnDropItemList(DnDVideo);
            if (DnDMusic.Count != 0)
                ucMusic1.CreateButtonWithDragnDropItemList(DnDMusic);
            if (DnDPicture.Count != 0)
                ucPicture1.CreateButtonWithDragnDropItemList(DnDPicture);
            DnDVideo.Clear();
            DnDPicture.Clear();
            DnDMusic.Clear();
        }

        private void fMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}

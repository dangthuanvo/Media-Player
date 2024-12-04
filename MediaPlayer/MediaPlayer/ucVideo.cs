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
using MediaPlayerCore;
using MediaPlayer.Properties;
using System.Windows.Media.Imaging;
using VisioForge.Types.OutputFormat;
using MediaToolCustom;
using WMPLib;
using System.Diagnostics;
using System.Media;
namespace MediaPlayer
{
    public partial class ucVideo : UserControl, IMessageFilter
    {
        int countVideo = 0;
        int currentindex = 0;
        public int indexnowplaying = 0;
        private string folderPath;
        List<MediaButton> listButton = new List<MediaButton>();
        List<Label> listLabel = new List<Label>();
        NonFlickerPannel panelVideo = new NonFlickerPannel();
        Size panelVideoOld;
        SoundPlayer sound = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound5.wav");
        SoundPlayer sound2 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound6.wav");
        SoundPlayer sound3 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound7.wav");
        public ucVideo()
        {
            InitializeComponent();
            tab1Video.Appearance = TabAppearance.FlatButtons;
            tab1Video.ItemSize = new Size(0, 1);
            tab1Video.SizeMode = TabSizeMode.Fixed;
            timer1.Stop();
            bunifuHSlider2.Value = playerVideo.settings.volume;
            backtodefaultButton.Visible = false;
            notiLabel.Visible = false;
            rcLabel.Visible = false;
            this.tabDefault.Controls.Add(panelVideo);
            panelVideo.BackgroundImage = Resources.bgVid;
            panelVideo.Dock = DockStyle.Fill;
            panelVideo.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.Visible = false;//new
            editButton.Visible = false;//new
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleParam = base.CreateParams;
        //        handleParam.ExStyle |= 0x02000000;
        //        return handleParam;
        //    }
        //}
        public bool check(string ex)
        {
            for (int i = 0; i < Global.indexVideo.Count(); i++)
            {
                if (Global.indexVideo[i].path == ex)
                    return false;
            }
            return true;
        }
        private void addfilesVideo_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listVideo = new List<MediaFileInfo>();
            bool alr = true;
            string ex = "MP4|*.mp4|AVI|*.avi|WMV|*.wmv|FLV|*.flv";
            listVideo = Import.ImportVideoFiles(ex);
            foreach (MediaFileInfo video in listVideo)
            {
                if (!check(video.path))
                {
                    MessageBox.Show("Video này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alr = false;
                }
                else
                {
                    CreateButton(video);
                    Global.UpdateHistory(Global.currentusername, "đã thêm đoạn phim " + video.title + "!");
                }
            }
            RelocaVideoButton(false);
            if (alr)
                Import.ShowMessageAddFileComplete("video", listVideo.Count());
            listVideo.Clear();
        }
        private void addfolderVideo_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listVideo = new List<MediaFileInfo>();
            bool alr = true;
            List<string> ex = new List<string> { "*.mp4", "*.avi", "*.wmv", "*.flv" };
            listVideo = Import.ImportVideoFolder(ref folderPath, ex);
            foreach (MediaFileInfo video in listVideo)
            {
                if (!check(video.path))
                {
                    MessageBox.Show("Video này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(video);
                    Global.UpdateHistory(Global.currentusername, "đã thêm đoạn phim " + video.title + "!");
                }
            }
            RelocaVideoButton(false);
            if (alr)
                Import.ShowMessageAddFileComplete("video", listVideo.Count());
            listVideo.Clear();
        }
        private static bool playing = true;
        void delClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            Global.UpdateHistory(Global.currentusername, "đã xoá đoạn phim " + Global.indexVideo[pos].title + "!");
            if (Global.indexVideo[pos].isFav == true)
            {
                Global.isUpdateFavVideo = true;
            }
            if (pos == currentindex)
            {
                currentindex = 0;
                backtodefaultButton.Visible = false;
            }
            else
                if (pos < currentindex)
                currentindex--;
            Global.indexVideo.RemoveAt(pos);
            listButton[pos].DisposeButton();
            listLabel[pos].Dispose();
            listLabel.RemoveAt(pos);
            listButton.RemoveAt(pos);
            countVideo--;
            for (int i = pos; i < countVideo; i++)
            {
                listButton[i].pos[0] = i;
                Global.indexVideo[i].pos[0] = i;
            }
            RelocaVideoButton();
            if (!Global.isMute)
                sound3.Play();
        }
        void favClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            if (!checkExists(Global.indexVideo[pos].path, pos))
            {
                return;
            }
            if (!Global.indexVideo[pos].isFav)
            {
                a.Image = Resources.fav;
                Global.indexVideo[pos].isFav = true;
                Global.UpdateHistory(Global.currentusername, "đã yêu thích đoạn phim " + Global.indexVideo[pos].title + "!");
                if (!Global.isMute)
                    sound2.Play();
            }
            else
            {
                a.Image = Resources.preheart2;
                Global.indexVideo[pos].isFav = false;
                Global.UpdateHistory(Global.currentusername, "đã bỏ yêu thích đoạn phim " + Global.indexVideo[pos].title + "!");
            }
            Global.isUpdateFavVideo = true;
        }
        private void playpauseButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playerVideo.Ctlcontrols.play();
                playing = true;
                playpauseButton.Image = Resources.pause;
            }
            else
            {
                playerVideo.Ctlcontrols.pause();
                playing = false;
                playpauseButton.Image = Resources.play;
            }
        }
        void videoClick(object sender, EventArgs e)
        {
            //playerVideo.currentPlaylist.clear();
            //playerVideo.close();
            timer1.Start();
            MediaButton a = sender as MediaButton;
            int pos = a.pos[0];
            if (!checkExists(Global.indexVideo[pos].path, pos))
            {
                return;
            }
            if (!playing)
            {
                playerVideo.Ctlcontrols.play();
                playing = true;
                playpauseButton.Image = Resources.pause;
            }
            tab1Video.SelectedIndex = 1;
            playerVideo.URL = a.Name;
            if(currentindex != pos)
            {
                editButton.Image = Resources.edit_32px;
                editting = false;
            }
            currentindex = pos;
            //bunifuTextBox1.Visible = false;
            backtodefaultButton.Visible = true;
            backtodefaultButton.Image = Resources.undo_32px;
            playerVideo.uiMode = "none";
            notiLabel.Visible = true;
            notiLabel.Text = "Đang phát: " + Global.indexVideo[currentindex].title;
            isdefault = false;
            //MessageBox.Show((int)Global.indexVideo[currentindex].duration.TotalSeconds + " ");
            bunifuHSlider1.Maximum = (int)Global.indexVideo[currentindex].duration.TotalSeconds;
            speedadjustDropBox.SelectedIndex = 2;
            ucVideo_getMess();
            bunifuPanel2.Visible = false;//new
            editButton.Visible = true;//new
            if (!Global.isMute)
            {
                sound.Play();
            }
        }
        bool isdefault = false;
        private void backtodefaultButton_Click(object sender, EventArgs e)
        {
            if(editting)
            {
                editting = false;
                range.RangeMin = 0;
                range.RangeMax = range.MaximumRange;
                bunifuPanel2.Visible = false;
                editButton.Image = Resources.edit_32px;
                return;
            }
            if (!isdefault)
            {
                timer1.Stop();
                if (playing)
                {
                    this.playpauseButton.PerformClick();
                }
                tab1Video.SelectedIndex = 0;
                isdefault = true;
                backtodefaultButton.Image = Resources.deundo;
                notiLabel.Visible = false;
                listShuffle.Clear();
                shuffle = false;
                //editting = false;//new
                editButton.Visible = false;//new
                ucVideo_removeMess();
            }
            else
            {
                if (countVideo != 0)
                    timer1.Start();
                tab1Video.SelectedIndex = 1;
                isdefault = false;
                backtodefaultButton.Image = Resources.undo_32px;
                notiLabel.Visible = true;
                ucVideo_getMess();
                if (editting)
                    editButton.Visible = true;
            }
        }

        private void fastButton_Click(object sender, EventArgs e)
        {
            playerVideo.Ctlcontrols.currentPosition += 10;
        }

        private void slowButton_Click(object sender, EventArgs e)
        {
            playerVideo.Ctlcontrols.currentPosition -= 10;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!shuffle)
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                }
                if (currentindex == countVideo - 1)
                    currentindex = 0;
                else
                    currentindex++;
                playerVideo.URL = Global.indexVideo[currentindex].path;
                notiLabel.Text = Global.indexVideo[currentindex].title + " is playing";
                bunifuHSlider1.Maximum = (int)Global.indexVideo[currentindex].duration.TotalSeconds;
            }
            else
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                }
                if (currentindexshuffle == countVideo - 1)
                    currentindexshuffle = 0;
                else
                    currentindexshuffle++;
                playerVideo.URL = Global.indexVideo[listShuffle[currentindexshuffle]].path;
                notiLabel.Text = Global.indexVideo[listShuffle[currentindexshuffle]].title + " is playing";
                bunifuHSlider1.Maximum = (int)Global.indexVideo[listShuffle[currentindexshuffle]].duration.TotalSeconds;
            }
            speedadjustDropBox.SelectedIndex = 2;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (!shuffle)
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                }
                if (currentindex == 0)
                    currentindex = countVideo - 1;
                else
                    currentindex--;
                playerVideo.URL = Global.indexVideo[currentindex].path;
                notiLabel.Text = Global.indexVideo[currentindex].title + " is playing";
                bunifuHSlider1.Maximum = (int)Global.indexVideo[currentindex].duration.TotalSeconds;
            }
            else
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                }
                if (currentindexshuffle == 0)
                    currentindexshuffle = countVideo - 1;
                else
                    currentindexshuffle--;
                playerVideo.URL = Global.indexVideo[listShuffle[currentindexshuffle]].path;
                notiLabel.Text = Global.indexVideo[listShuffle[currentindexshuffle]].title + " is playing";
                bunifuHSlider1.Maximum = (int)Global.indexVideo[listShuffle[currentindexshuffle]].duration.TotalSeconds;
            }
            speedadjustDropBox.SelectedIndex = 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = playerVideo.Ctlcontrols.currentPositionString;
            bunifuHSlider1.Value = (int)playerVideo.Ctlcontrols.currentPosition;
            if(editting)
            {
                if (playerVideo.Ctlcontrols.currentPosition >= range.RangeMax || playerVideo.Ctlcontrols.currentPosition < range.RangeMin)
                {
                    (playerVideo.Ctlcontrols.currentPosition) = range.RangeMin;
                    playerVideo.Ctlcontrols.play();
                }
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                if (!isloop)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        nextButton.PerformClick();
                    }));
                }
                else
                {
                    bunifuHSlider1.Value = 0;
                    playerVideo.Ctlcontrols.play();
                    playerVideo.settings.rate = currentrate;
                }
            }
        }
        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            playerVideo.settings.volume = bunifuHSlider2.Value;
            muteButton.Image = Resources.max;
        }
        private void bunifuHSlider1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                playerVideo.Ctlcontrols.pause();
                return;
            }
            if (playing)
            {
                playerVideo.Ctlcontrols.play();
                playerVideo.settings.rate = currentrate;
            }
        }
        private void bunifuHSlider1_Scroll_1(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            playerVideo.Ctlcontrols.currentPosition = bunifuHSlider1.Value;
            System.Threading.Thread.Sleep(25);
        }
        bool mute = false;

        public IVFVideoCaptureBaseOutput VFMP4Outputv11 { get; private set; }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                mute = true;
                bunifuHSlider2.Value = 0;
                playerVideo.settings.volume = 0;
                muteButton.Image = Resources.mute;
            }
            else
            {
                mute = false;
                bunifuHSlider2.Value = 50;
                playerVideo.settings.volume = 50;
                muteButton.Image = Resources.max;
            }
        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                for (int i = 0; i < countVideo; i++)
                {
                    listButton[i].Visible = true;
                    listLabel[i].Visible = true;
                }
                RelocaVideoButton();
                return;
            }
            for (int i = 0; i < countVideo; i++)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Global.indexVideo[i].title, bunifuTextBox1.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    listButton[i].Visible = false;
                    listLabel[i].Visible = false;
                }
                else
                {
                    listButton[i].Visible = true;
                    listLabel[i].Visible = true;
                }
            }
            RelocaVideoButton();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            videoCapture1.Video_CaptureDevice = videoCapture1.Video_CaptureDevicesInfo[0].Name;
            videoCapture1.Audio_CaptureDevice = videoCapture1.Audio_CaptureDevicesInfo[0].Name;
            string ex = "avi|*.avi";
            string path = null;
            path = Import.SaveMedia(ex);
            if (!String.IsNullOrEmpty(path))
            {
                rcLabel.Visible = true;
                globalpath = path;
                videoCapture1.Output_Filename = path;
                videoCapture1.Output_Format = new VFAVIOutput();
                videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
                videoCapture1.Start();
            }
            else
                MessageBox.Show("Đường dẫn không hợp lệ!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        string globalpath = "";
        private void stopButton_Click(object sender, EventArgs e)
        {
            rcLabel.Visible = false;
            videoCapture1.Stop();
            List<string> a = new List<string>();
            a.Add(globalpath);
            CreateButton(Import.GetListVideoFromFilePaths(a)[0]);
            RelocaVideoButton(false);
        }

        private void Film_Click(object sender, EventArgs e)
        {
            tab1Video.SelectedIndex = 2;
            listShuffle.Clear();
            shuffle = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            tab1Video.SelectedIndex = 0;
        }
        public void CreateButton(MediaFileInfo video)
        {
            Label label = new Label();
            MediaButton btn = new MediaButton(countVideo);
            video.pos[0] = countVideo;
            Image img = System.Drawing.Image.FromStream(video.image, true, true);
            Image oldImage = img;
            img = ImageControl.FitImgToPictureBox(img, btn.Size);
            oldImage.Dispose();
            btn.Image = img;
            btn.Name = video.path;
            btn.Click += new EventHandler(this.videoClick);
            btn.fav.Click += new EventHandler(this.favClick);
            btn.era.Click += new EventHandler(this.delClick);
            if (video.isFav == true)
            {
                btn.fav.Image = Resources.fav;
                Global.isUpdateFavVideo = true;
            }
            label.Text = video.title;
            label.AutoSize = false;
            label.BackColor = Color.BlueViolet;
            label.Font = new Font("Consolas", 12);
            label.Size = new Size(btn.Width, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            Global.indexVideo.Add(video);
            listButton.Add(btn);
            listLabel.Add(label);
            panelVideo.Controls.Add(btn);
            panelVideo.Controls.Add(label);
            countVideo++;
        }
        public void RelocaVideoButton(bool checkVisible = true)
        {
            panelVideoOld = panelVideo.Size;
            if (!checkVisible)
            {
                bunifuTextBox1.Text = "";
            }
            panelVideo.Invalidate();
            if (countVideo == 0)
            {
                return;
            }
            int deltaW = 5000;
            int col_count = 1;
            int btnW = listButton[0].Width;
            int pnlW = panelVideo.Width;
            for (int j = 2; j <= 10; j++)
            {
                if ((pnlW - btnW - 32) / (j - 1) - btnW > 5)
                {
                    deltaW = Math.Min(deltaW, (pnlW - btnW - 32) / (j - 1) - btnW);
                    col_count = j;
                }
                else
                {
                    break;
                }
            }
            if (deltaW == 5000)
            {
                deltaW = 10;
            }
            int i = 0;
            int old_i = 0;
            panelVideo.AutoScroll = false;
            for (int j = 0; j < countVideo; j++)
            {
                if (listButton[j].Visible == true || !checkVisible)
                {
                    if (i == 0)
                    {
                        listButton[j].Location = new Point(7, 3);
                    }
                    else
                    {
                        if (i % col_count == 0)
                        {
                            listButton[j].Location = new Point(7, listButton[old_i].Location.Y + listButton[old_i].Height + listLabel[j].Height + deltaW);
                        }
                        else
                        {
                            listButton[j].Location = new Point(listButton[old_i].Location.X + listButton[old_i].Width + deltaW, listButton[old_i].Location.Y);
                        }
                    }
                    listLabel[j].Location = new Point(listButton[j].Location.X, listButton[j].Location.Y + listButton[j].Height);
                    old_i = j;
                    i++;
                }

            }
            panelVideo.AutoScroll = true;
        }
        public void WantToPLayIndex(int idx)
        {
            if (!isdefault)
            {
                this.backtodefaultButton.PerformClick();
            }
            listButton[idx].PerformClick();
        }
        bool isloop = false;
        private void loopButton_Click(object sender, EventArgs e)
        {
            if (!isloop)
            {
                loopButton.BackColor = Color.Indigo;
                isloop = true;
            }
            else
            {
                loopButton.BackColor = Color.SlateBlue;
                isloop = false;
            }
        }
        bool shuffle = false;
        int currentindexshuffle;
        List<int> listShuffle = new List<int>();
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            shuffle = true;
            for (int i = 0; i < Global.indexVideo.Count; i++)
                listShuffle.Add(i);
            listShuffle = listShuffle.OrderBy(i => Guid.NewGuid()).ToList();
            listButton[listShuffle[0]].PerformClick();
            currentindexshuffle = 0;
        }
        public void CreateButtonWithUserData()
        {
            if (!Global.isNonUser)
            {
                List<bool> Fav = new List<bool>();
                List<MediaFileInfo> listVideo = new List<MediaFileInfo>();
                List<string> lines = new List<string>();
                int count;
                Global.GetPathsinData(Global.currentvideopath, ref Fav, ref lines);
                listVideo = Import.GetListVideoFromFilePaths(new List<string>(lines));
                count = listVideo.Count();
                for (int i = 0; i < count; i++)
                {
                    listVideo[i].isFav = (Fav[i]) ? true : false;
                }
                foreach (MediaFileInfo Video in listVideo)
                {
                    if (check(Video.path))
                    {
                        Video.pos[0] = countVideo;
                        CreateButton(Video);
                    }
                }
                RelocaVideoButton(false);
                listVideo.Clear();
                Fav.Clear();
                lines.Clear();
            }
        }
        public void CreateButtonWithDragnDropItemList(List<string> a)
        {
            List<MediaFileInfo> listVideo = new List<MediaFileInfo>();
            listVideo = Import.GetListVideoFromFilePaths(a);
            bool alr = true;
            foreach (MediaFileInfo video in listVideo)
            {
                if (!check(video.path))
                {
                    MessageBox.Show("Video này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(video);
                    Global.UpdateHistory(Global.currentusername, "đã thêm đoạn phim " + video.title + "!");
                }
            }
            RelocaVideoButton(false);
            if (alr)
            {
                Import.ShowMessageAddFileComplete("video", listVideo.Count());
            }
            listVideo.Clear();
        }
        private void ucVideo_Paint(object sender, PaintEventArgs e)
        {
            if (panelVideoOld != panelVideo.Size)
            {
                RelocaVideoButton();
            }
        }
        public void DeleteAllData()
        {
            while (countVideo > 0)
            {
                listButton[0].era.PerformClick();
            }
        }

        bool checkExists(string _path, int idx)
        {
            if (!File.Exists(_path))
            {
                MessageBox.Show("Phương tiện hiện không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listButton[idx].era.PerformClick();
                return false;
            }
            return true;
        }
        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            playerVideo.fullScreen = true;
        }
        #region IMessageFilter Members
        private const UInt32 WM_KEYDOWN = 0x0100;
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                if (keyCode == Keys.Space)
                {
                    playpauseButton.PerformClick();
                }
                if (keyCode == Keys.Escape)
                {
                    playerVideo.fullScreen = false;
                }
                if (keyCode == Keys.Right)
                {
                    fastButton.PerformClick();
                }
                if (keyCode == Keys.Left)
                {
                    slowButton.PerformClick();
                }
                if (keyCode == Keys.Up)
                {
                    playerVideo.settings.volume += 5;
                    bunifuHSlider2.Value += 5;
                    if (bunifuHSlider2.Value != 0)
                    {
                        muteButton.Image = Resources.max;
                        mute = false;
                    }
                }
                if (keyCode == Keys.Down)
                {
                    playerVideo.settings.volume -= 5;
                    bunifuHSlider2.Value -= 5;
                    if (bunifuHSlider2.Value == 0)
                    {
                        muteButton.Image = Resources.mute;
                        mute = true;
                    }
                }
                if (keyCode == Keys.M)
                {
                    muteButton.PerformClick();
                }
                return true;
            }
            return false;
        }
        #endregion
        public void ucVideo_getMess()
        {
            Application.AddMessageFilter(this);
        }
        public void ucVideo_removeMess()
        {
            Application.RemoveMessageFilter(this);
        }
        public void UpdateVideoFromYoutube()
        {
            if (Global.VideoYoutube.Count > 0)
            {
                foreach (MediaFileInfo info in Global.VideoYoutube)
                {
                    WindowsMediaPlayer player = new WindowsMediaPlayer();
                    IWMPMedia audioInfo = player.newMedia(info.path);
                    info.duration = TimeSpan.FromSeconds((int)audioInfo.duration);
                    CreateButton(info);
                }
                RelocaVideoButton();
                Global.VideoYoutube.Clear();
            }
        }
        double currentrate = 1;
        private void speedadjustDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (speedadjustDropBox.SelectedIndex == 0)
            {
                playerVideo.settings.rate = 0.25;
                currentrate = 0.25;
            }
            if (speedadjustDropBox.SelectedIndex == 1)
            {
                playerVideo.settings.rate = 0.5;
                currentrate = 0.5;
            }
            if (speedadjustDropBox.SelectedIndex == 2)
            {
                playerVideo.settings.rate = 1;
                currentrate = 1;
            }
            if (speedadjustDropBox.SelectedIndex == 3)
            {
                playerVideo.settings.rate = 2;
                currentrate = 2;
            }
            if (speedadjustDropBox.SelectedIndex == 4)
            {
                playerVideo.settings.rate = 4;
                currentrate = 4;
            }
        }
        public int GetCurrentTab()
        {
            return tab1Video.SelectedIndex;
        }
        int tmprangemin = 0;
        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            if (range.RangeMin != tmprangemin)
            {
                playerVideo.Ctlcontrols.currentPosition = range.RangeMin;
            }
            tmprangemin = range.RangeMin;
            System.Threading.Thread.Sleep(50);
        }
        bool editting = false;
        private void editButton_Click(object sender, EventArgs e)
        {
            if (editting == false) // các set up cơ bản để bắt đầu trim Video
            {
                editButton.Image = Resources.save_24px;
                bunifuPanel2.Visible = true;
                editting = true;
                playerVideo.Ctlcontrols.currentPosition = 0;
                bunifuHSlider1.Value = 0;
                range.MaximumRange = (int)Global.indexVideo[currentindex].duration.TotalSeconds;
                range.RangeMin = 0;
                range.RangeMax = range.MaximumRange;
            }
            else
            {
                string tmpex = Path.GetExtension(Global.indexVideo[currentindex].path);
                tmpex = tmpex.Remove(tmpex.IndexOf('.'), 1);
                string ex = tmpex + "|*." + tmpex;
                string path = null;
                path = Import.SaveMediaProForVideo(Global.indexVideo[currentindex].path, currentindex);
                if (!String.IsNullOrEmpty(path))
                {
                    string outputfolder = path.Substring(0, path.LastIndexOf(@"\") + 1);
                    string outputname = Path.GetFileNameWithoutExtension(path);
                    string extension = '.' + tmpex;
                    string inputfile = Global.indexVideo[currentindex].path;
                    int start = range.RangeMin;
                    int end = range.RangeMax - range.RangeMin;
                    string outputFilename = $@"{outputfolder}\{outputname}{extension}";
                    string command = $"-i \"{inputfile}\" -ss {start} -t {end} \"{outputFilename}\"";
                    using (Process proc = new Process())
                    {
                        proc.StartInfo.FileName = "ffmpeg";
                        proc.StartInfo.Arguments = command;
                        proc.StartInfo.RedirectStandardError = true;
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.CreateNoWindow = true;
                        if (!proc.Start())
                        {
                            Console.WriteLine("Error starting");
                            return;
                        }
                        StreamReader reader = proc.StandardError;
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                        proc.Close();
                    }
                    MessageBox.Show("Xử lí hoàn tất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editButton.Image = Resources.edit_32px;
                    bunifuPanel2.Visible = false;
                    editting = false;
                    List<string> a = new List<string>();
                    a.Add(path);
                    CreateButton(Import.GetListVideoFromFilePaths(a)[0]);
                    RelocaVideoButton(false);
                    range.RangeMin = 0;
                    range.RangeMax = range.MaximumRange;
                    editting = false;
                }
                else
                {
                    MessageBox.Show("Đường dẫn không hợp lệ!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

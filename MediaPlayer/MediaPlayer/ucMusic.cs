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
using System.Media;
using MediaPlayerCore;
using MediaPlayer.Properties;
using VisioForge.Types.OutputFormat;
using MediaToolCustom;
using System.Runtime.InteropServices;
using Bunifu.UI.WinForms;
using WMPLib;
using System.Diagnostics;

namespace MediaPlayer
{

    public partial class ucMusic : UserControl, IMessageFilter
    {
        int countMusic = 0;
        int currentindex = 0;
        public int indexnowplaying = 0;
        //panel chứa button được tạo ở đây
        NonFlickerPannel panelMusic = new NonFlickerPannel();   
        Size panelMusicOld;
        private string folderPath;
        List<MediaButton> listButton = new List<MediaButton>();
        List<Label> listLabel = new List<Label>();
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.None, SetLastError = true)]
        private static extern int record1(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        SoundPlayer sound = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound5.wav");
        SoundPlayer sound2 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound6.wav");
        SoundPlayer sound3 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound7.wav");
        public ucMusic()
        {
            InitializeComponent();
            tab1Music.Appearance = TabAppearance.FlatButtons;
            tab1Music.ItemSize = new Size(0, 1);
            tab1Music.SizeMode = TabSizeMode.Fixed;
            timer1.Stop();
            bunifuHSlider2.Value = playerMusic.settings.volume;
            backtodefaultButton.Visible = false;
            rcLabel.Visible = false;
            this.DoubleBuffered = true;
            this.tabDefault.Controls.Add(panelMusic);
            pictureBox1.Enabled = false;
            panelMusic.Dock = DockStyle.Fill;
            panelMusic.BackgroundImage = Resources.bgMus;
            panelMusic.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.Visible = false;//new
            editButton.Visible = false;//new

        }
        //Bật double buffer toàn uc, nhưng pannel có vẻ hơi lag
        //Xem bên máy khác có bị lag vậy không thì bật hàm này lên
        //3 uc control kia đều có hàm này.
        //pannel để chứa các button không được tạo bên design 
        //thêm lại ảnh nền bằng code 
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

            for (int i = 0; i < Global.indexMusic.Count(); i++)
            {
                if (Global.indexMusic[i].path == ex)
                    return false;
            }
            return true;
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listMusic = new List<MediaFileInfo>();
            bool alr = true;
            string ex = "MP3|*.mp3|FLAC|*.flac|WAV|*.wav";
            listMusic = Import.ImportMusicFiles(ex);
            foreach (MediaFileInfo music in listMusic)
            {
                if (!check(music.path))
                {
                    MessageBox.Show("Bài hát này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alr = false;
                }
                else
                {
                    CreateButton(music);
                    Global.UpdateHistory(Global.currentusername, "đã thêm bài hát " + music.title + "!");
                }
            }
            RelocaMusicButton(false);
            if (alr)
                Import.ShowMessageAddFileComplete("bài hát", listMusic.Count());
            listMusic.Clear();
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listMusic = new List<MediaFileInfo>();
            bool alr = true;
            List<string> ex = new List<string> { "*.mp3", "*.flac", "*.wav", "*.aac" };
            listMusic = Import.ImportMusicFolder(ref folderPath, ex);
            foreach (MediaFileInfo music in listMusic)
            {
                if (!check(music.path))
                {
                    MessageBox.Show(null, "Bài hát này đã được thêm trước đó!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(music);
                    Global.UpdateHistory(Global.currentusername, "đã thêm bài hát " + music.title + "!");
                }
            }
            RelocaMusicButton(false);
            if (alr)
                Import.ShowMessageAddFileComplete("bài hát", listMusic.Count());
            listMusic.Clear();
        }
        private static bool playing = true;
        private void playpauseButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playerMusic.Ctlcontrols.play();
                playing = true;
                playpauseButton.Image = Resources.pause;
                pictureBoxGif.Enabled = true;
            }
            else
            {
                playerMusic.Ctlcontrols.pause();
                playing = false;
                playpauseButton.Image = Resources.play;
                pictureBoxGif.Enabled = false;
            }
        }
        public void infoDisplay(int i)
        {
            labelTitle.Text = Global.indexMusic[i].title;
            labelAuthor.Text = Global.indexMusic[i].artist;
            labelDuration.Text = Global.indexMusic[i].duration.ToString();
        }
        void musicClick(object sender, EventArgs e)
        {
            timer1.Start();
            MediaButton a = sender as MediaButton;
            int pos = a.pos[0];
            if (!checkExists(Global.indexMusic[pos].path, pos))
            {
                return;
            }
            playerMusic.URL = a.Name;
            if (!playing)
            {
                playerMusic.Ctlcontrols.play();
                playing = true;
                playpauseButton.Image = Resources.pause;
                pictureBoxGif.Enabled = true;
            }
            tab1Music.SelectedIndex = 1;
            if (currentindex != pos)
            {
                editButton.Image = Resources.edit_32px;
                editting = false;
            }
            currentindex = pos;
            infoDisplay(currentindex);
            //bunifuTextBox1.Visible = false;
            backtodefaultButton.Visible = true;
            backtodefaultButton.Image = Resources.undo_32px;
            isdefault = false;
            //MessageBox.Show((int)Global.indexMusic[currentindex].duration.TotalSeconds + " ");
            bunifuHSlider1.Maximum = (int)Global.indexMusic[currentindex].duration.TotalSeconds;
            speedadjustDropBox.SelectedIndex = 2;
            ucMusic_getMess();
            bunifuPanel2.Visible = false;//new
            editButton.Visible = true;//new
            if (!Global.isMute)
                sound.Play();
        }
        void delClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            Global.UpdateHistory(Global.currentusername, "đã xoá bài hát " + Global.indexMusic[pos].title + "!");
            if (Global.indexMusic[pos].isFav == true)
            {
                Global.isUpdateFavMusic = true;
            }
            if (pos == currentindex)
            {
                currentindex = 0;
                backtodefaultButton.Visible = false;
            }
            else
                if (pos < currentindex)
                currentindex--;
            Global.indexMusic.RemoveAt(pos);
            listButton[pos].DisposeButton();
            listLabel[pos].Dispose();
            listLabel.RemoveAt(pos);
            listButton.RemoveAt(pos);
            countMusic--;
            for (int i = pos; i < countMusic; i++)
            {
                listButton[i].pos[0] = i;
                Global.indexMusic[i].pos[0] = i;
            }
            if (!Global.isMute)
                sound3.Play();
            RelocaMusicButton();
        }
        void favClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            if (!checkExists(Global.indexMusic[pos].path, pos))
            {
                return;
            }
            if (!Global.indexMusic[pos].isFav)
            {
                a.Image = Resources.fav;
                Global.indexMusic[pos].isFav = true;
                Global.UpdateHistory(Global.currentusername, "đã yêu thích bài hát " + Global.indexMusic[pos].title + "!");
                if (!Global.isMute)
                    sound2.Play();
            }
            else
            {
                a.Image = Resources.preheart2;
                Global.indexMusic[pos].isFav = false;
                Global.UpdateHistory(Global.currentusername, "đã bỏ yêu thích bài hát " + Global.indexMusic[pos].title + "!");
            }
            Global.isUpdateFavMusic = true;

        }
        bool isdefault = false;
        private void backtodefaultButton_Click(object sender, EventArgs e)
        {
            if (editting)
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
                if (playing)
                {
                    playerMusic.Ctlcontrols.pause();
                    playing = false;
                    playpauseButton.Image = Resources.play;
                }
                tab1Music.SelectedIndex = 0;
                isdefault = true;
                backtodefaultButton.Image = Resources.deundo;
                timer1.Start();
                listShuffle.Clear(); //
                shuffle = false; //
                editButton.Visible = false;//new
                ucMusic_removeMess();

            }
            else
            {
                tab1Music.SelectedIndex = 1;
                isdefault = false;
                backtodefaultButton.Image = Resources.undo_32px;
                timer1.Stop();
                ucMusic_getMess();
            }
        }
        private void fastButton_Click(object sender, EventArgs e)
        {
            playerMusic.Ctlcontrols.currentPosition += 10;
        }

        private void slowButton_Click(object sender, EventArgs e)
        {
            playerMusic.Ctlcontrols.currentPosition -= 10;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!shuffle)
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                    pictureBoxGif.Enabled = true;
                }
                if (currentindex == countMusic - 1)
                    currentindex = 0;
                else
                    currentindex++;
                playerMusic.URL = Global.indexMusic[currentindex].path;
                infoDisplay(currentindex);
                bunifuHSlider1.Maximum = (int)Global.indexMusic[currentindex].duration.TotalSeconds;
            }
            else
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                    pictureBoxGif.Enabled = true;
                }
                if (currentindexshuffle == countMusic - 1)
                    currentindexshuffle = 0;
                else
                    currentindexshuffle++;
                playerMusic.URL = Global.indexMusic[listShuffle[currentindexshuffle]].path;
                infoDisplay(Global.indexMusic[listShuffle[currentindexshuffle]].pos[0]);
                bunifuHSlider1.Maximum = (int)Global.indexMusic[listShuffle[currentindexshuffle]].duration.TotalSeconds;
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
                    pictureBoxGif.Enabled = true;
                }
                if (currentindex == 0)
                    currentindex = countMusic - 1;
                else
                    currentindex--;
                playerMusic.URL = Global.indexMusic[currentindex].path;
                infoDisplay(currentindex);
                bunifuHSlider1.Maximum = (int)Global.indexMusic[currentindex].duration.TotalSeconds;
            }
            else
            {
                if (!playing)
                {
                    playpauseButton.Image = Resources.pause;
                    pictureBoxGif.Enabled = true;
                }
                if (currentindexshuffle == 0)
                    currentindexshuffle = countMusic - 1;
                else
                    currentindexshuffle--;
                playerMusic.URL = Global.indexMusic[listShuffle[currentindexshuffle]].path;
                infoDisplay(Global.indexMusic[listShuffle[currentindexshuffle]].pos[0]);
                bunifuHSlider1.Maximum = (int)Global.indexMusic[listShuffle[currentindexshuffle]].duration.TotalSeconds;
            }
            speedadjustDropBox.SelectedIndex = 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = playerMusic.Ctlcontrols.currentPositionString;
            bunifuHSlider1.Value = (int)playerMusic.Ctlcontrols.currentPosition;
            if (editting)
            {
                if (playerMusic.Ctlcontrols.currentPosition >= range.RangeMax || playerMusic.Ctlcontrols.currentPosition < range.RangeMin)
                {
                    (playerMusic.Ctlcontrols.currentPosition) = range.RangeMin;
                    playerMusic.Ctlcontrols.play();
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
                    playerMusic.Ctlcontrols.play();
                    playerMusic.settings.rate = currentrate;
                }
            }
        }
        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            playerMusic.Ctlcontrols.currentPosition = bunifuHSlider1.Value;
            //System.Threading.Thread.Sleep(1);
        }
        private void bunifuHSlider1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                playerMusic.Ctlcontrols.pause();
                return;
            }
            if (playing)
            {
                playerMusic.Ctlcontrols.play();
                playerMusic.settings.rate = currentrate;
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                for (int i = 0; i < countMusic; i++)
                {
                    listButton[i].Visible = true;
                    listLabel[i].Visible = true;
                }
                RelocaMusicButton();
                return;
            }
            for (int i = 0; i < countMusic; i++)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Global.indexMusic[i].title, bunifuTextBox1.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
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
            RelocaMusicButton();
        }
        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            playerMusic.settings.volume = bunifuHSlider2.Value;
            muteButton.Image = Resources.max;
        }
        bool mute = false;
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                mute = true;
                bunifuHSlider2.Value = 0;
                playerMusic.settings.volume = 0;
                muteButton.Image = Resources.mute;
            }
            else
            {
                mute = false;
                bunifuHSlider2.Value = 50;
                playerMusic.settings.volume = 50;
                muteButton.Image = Resources.max;
            }
        }
        string globalpath = "";
        private void startButton_Click(object sender, EventArgs e)
        {
            string ex = "wav|*.wav";
            string path = "";
            path = Import.SaveMedia(ex);
            if (!String.IsNullOrEmpty(path))
            {
                globalpath = path;
                record1("open new Type waveaudio Alias recsound", "", 0, 0);
                record1("record recsound", "", 0, 0);
                rcLabel.Visible = true;
                pictureBox1.Enabled = true;
            }
            else
                MessageBox.Show("Đường dẫn không hợp lệ!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            rcLabel.Visible = false;
            record1("save recsound " + globalpath, "", 0, 0);
            record1("close recsound", "", 0, 0);
            List<string> a = new List<string>();
            a.Add(globalpath);
            MediaFileInfo info = Import.GetListMusicFromFilePaths(a)[0];
            CreateButton(info);
            RelocaMusicButton(false);
            pictureBox1.Enabled = false;
        }
        private void Record_Click(object sender, EventArgs e)
        {
            tab1Music.SelectedIndex = 2;
            listShuffle.Clear();
            shuffle = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            tab1Music.SelectedIndex = 0;
        }

        public void CreateButton(MediaFileInfo music)
        {
            Label label = new Label();
            MediaButton btn = new MediaButton(countMusic);
            music.pos[0] = countMusic;
            Image img;
            try
            {
                img = System.Drawing.Image.FromStream(music.image, true, true);
            }
            catch
            {
                img = Resources.music;
            }
            Image oldImage = img;
            img = ImageControl.FitImgToPictureBox(img, btn.Size);
            oldImage.Dispose();
            btn.Image = img;
            btn.Name = music.path;
            btn.Click += new EventHandler(this.musicClick);
            btn.fav.Click += new EventHandler(this.favClick);
            btn.era.Click += new EventHandler(this.delClick);
            if (music.isFav == true)
            {
                btn.fav.Image = Resources.fav;
                Global.isUpdateFavMusic = true;
            }

            label.Text = music.fileName;
            label.AutoSize = false;
            label.BackColor = Color.BlueViolet;
            label.Font = new Font("Consolas", 12);
            label.Size = new Size(btn.Width, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            Global.indexMusic.Add(music);
            listButton.Add(btn);
            listLabel.Add(label);
            panelMusic.Controls.Add(btn);
            panelMusic.Controls.Add(label);

            countMusic++;
        }

        public void RelocaMusicButton(bool checkVisible = true)
        {
            panelMusicOld = panelMusic.Size;
            if (!checkVisible)
            {
                bunifuTextBox1.Text = "";
            }
            panelMusic.Invalidate();
            if (countMusic == 0)
            {
                return;
            }
            int deltaW = 5000;
            int col_count = 1;
            int btnW = listButton[0].Width;
            int pnlW = panelMusic.Width;
            for (int j = 2; j <= 10; j++)
            {
                //MessageBox.Show(j.ToString() + " " + ((pnlW - btnW - 32) / (j - 1) - btnW).ToString());
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
            panelMusic.AutoScroll = false;
            for (int j = 0; j < countMusic; j++)
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
            panelMusic.AutoScroll = true;
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
            for (int i = 0; i < Global.indexMusic.Count; i++)
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
                List<MediaFileInfo> listMusic = new List<MediaFileInfo>();
                List<string> lines = new List<string>();
                int count;
                Global.GetPathsinData(Global.currentmusicpath, ref Fav, ref lines);
                listMusic = Import.GetListMusicFromFilePaths(new List<string>(lines));
                count = listMusic.Count();
                for (int i = 0; i < count; i++)
                {
                    listMusic[i].isFav = (Fav[i]) ? true : false;
                }
                foreach (MediaFileInfo Music in listMusic)
                {
                    if (check(Music.path))
                    {
                        CreateButton(Music);
                    }
                }
                RelocaMusicButton(false);
                listMusic.Clear();
                Fav.Clear();
                lines.Clear();
            }
        }
        public void CreateButtonWithDragnDropItemList(List<string> a)
        {
            List<MediaFileInfo> listMusic = new List<MediaFileInfo>();
            listMusic = Import.GetListMusicFromFilePaths(a);
            bool alr = true;
            foreach (MediaFileInfo music in listMusic)
            {
                if (!check(music.path))
                {
                    MessageBox.Show("Bài hát này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(music);
                    Global.UpdateHistory(Global.currentusername, "đã thêm bài hát " + music.title + "!");
                }
            }
            RelocaMusicButton(false);
            if (alr)
            {
                Import.ShowMessageAddFileComplete("bài hát", listMusic.Count());
            }
            listMusic.Clear();
        }
        private void ucMusic_Paint(object sender, PaintEventArgs e)
        {
            if (panelMusicOld != panelMusic.Size)
            {
                RelocaMusicButton();
            }
        }

        public void DeleteAllData()
        {
            while (countMusic > 0)
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
        #region IMessageFilter Members
        private const UInt32 WM_KEYDOWN = 0x0100;
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                if(keyCode == Keys.Space)
                {
                    playpauseButton.PerformClick();
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
                    playerMusic.settings.volume += 5;
                    bunifuHSlider2.Value += 5;
                    if (bunifuHSlider2.Value != 0)
                    {
                        muteButton.Image = Resources.max;
                        mute = false;
                    }
                }
                if (keyCode == Keys.Down)
                {
                    playerMusic.settings.volume -= 5;
                    bunifuHSlider2.Value -= 5;
                    if (bunifuHSlider2.Value == 0)
                    {
                        muteButton.Image = Resources.mute;
                        mute = true;
                    }
                }
                if(keyCode == Keys.M)
                {
                    muteButton.PerformClick();
                }
                return true;
            }
            return false;
        }
        #endregion
        public void ucMusic_getMess()
        {
            Application.AddMessageFilter(this);
        }
        public void ucMusic_removeMess()
        {
            Application.RemoveMessageFilter(this);
        }

        public void UpdateAudioFromYoutube()
        {
            if (Global.AudioYoutube.Count > 0)
            {
                foreach (MediaFileInfo info in Global.AudioYoutube)
                {
                    WindowsMediaPlayer player = new WindowsMediaPlayer();
                    IWMPMedia audioInfo = player.newMedia(info.path);
                    info.duration = TimeSpan.FromSeconds((int)audioInfo.duration);
                    CreateButton(info);
                }
                RelocaMusicButton();
                Global.AudioYoutube.Clear();
            }
        }
        double currentrate = 1;
        private void speedadjustDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (speedadjustDropBox.SelectedIndex == 0)
            {
                playerMusic.settings.rate = 0.25;
                currentrate = 0.25;
            }
            if (speedadjustDropBox.SelectedIndex == 1)
            {
                playerMusic.settings.rate = 0.5;
                currentrate = 0.5;
            }
            if (speedadjustDropBox.SelectedIndex == 2)
            {
                playerMusic.settings.rate = 1;
                currentrate = 1;
            }
            if (speedadjustDropBox.SelectedIndex == 3)
            {
                playerMusic.settings.rate = 2;
                currentrate = 2;
            }
            if (speedadjustDropBox.SelectedIndex == 4)
            {
                playerMusic.settings.rate = 4;
                currentrate = 4;
            }
        }
        public int GetCurrentTab()
        {
            return tab1Music.SelectedIndex;
        }
        bool editting = false;
        private void editButton_Click(object sender, EventArgs e)
        {
            if (editting == false)
            {
                editButton.Image = Resources.save_24px;
                bunifuPanel2.Visible = true;
                editting = true;
                playerMusic.Ctlcontrols.currentPosition = 0;
                bunifuHSlider1.Value = 0;
                range.MaximumRange = (int)Global.indexMusic[currentindex].duration.TotalSeconds;
                range.RangeMin = 0;
                range.RangeMax = range.MaximumRange;
            }
            else
            {
                string tmpex = Path.GetExtension(Global.indexMusic[currentindex].path);
                tmpex = tmpex.Remove(tmpex.IndexOf('.'), 1);
                string ex = tmpex + "|*." + tmpex;
                string path = null;
                path = Import.SaveMediaProForAudio(Global.indexMusic[currentindex].path, currentindex);
                if (!String.IsNullOrEmpty(path))
                {
                    string outputfolder = path.Substring(0, path.LastIndexOf(@"\") + 1);
                    string outputname = Path.GetFileNameWithoutExtension(path);
                    string extension = '.' + tmpex;
                    string inputfile = Global.indexMusic[currentindex].path;
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
                        try
                        {
                            using (TagLib.File tag = TagLib.File.Create(path))
                            {
                                tag.Tag.Title = Global.indexMusic[currentindex].title;
                                tag.Tag.Pictures = new TagLib.IPicture[1]
                                {
                                    new TagLib.Picture(new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter().ConvertTo(System.Drawing.Image.FromStream(Global.indexMusic[currentindex].image), typeof(byte[]))))
                                };
                                tag.Save();
                            }
                        }
                        catch { }
                    }
                    MessageBox.Show("Xử lí hoàn tất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editButton.Image = Resources.edit_32px;
                    bunifuPanel2.Visible = false;
                    editting = false;
                    List<string> a = new List<string>();
                    a.Add(path);
                    CreateButton(Import.GetListMusicFromFilePaths(a)[0]);
                    RelocaMusicButton(false);
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
        int tmprangemin = 0;
        private void range_RangeChanged(object sender, EventArgs e)
        {
            if (range.RangeMin != tmprangemin)
            {
                playerMusic.Ctlcontrols.currentPosition = range.RangeMin;
            }
            tmprangemin = range.RangeMin;
            System.Threading.Thread.Sleep(50);
        }
    }
}

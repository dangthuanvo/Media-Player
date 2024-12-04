using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerCore;
using System.IO;
using MediaToolCustom;
using MediaPlayer.Properties;
using System.Net.Http;
using System.Text.RegularExpressions;
using CefSharp;
using CefSharp.WinForms;
using MediaToolkit;
using VideoLibrary;
using System.Collections;
using System.Threading;

namespace MediaPlayer
{
    public partial class ucYoutube : UserControl
    {
        bool isYoutubeGlobal = false;
        List<MediaFileInfo> listYoutube;
        List<MediaButton> listButton;
        List<Label> listLabel;
        NonFlickerPannel panelYoutube;
        Size panelYoutubeOld;
        int currentPos;
        int countVideo = 0;
        static readonly HttpClient httpClient = new HttpClient();
        string urlSearch = @"https://www.youtube.com/results?search_query=";
        string exThumbnail = "\":{\"thumbnails\":(.*?){\"url\":\"(.*?)\"";
        string exTitle = "\"title\":{\"runs\":(.*?){\"text\":\"(.*?)\"}";
        string exUrl = "webCommandMetadata\":{\"url\":\"/watch(.*?)\",";
        string urlYoutube = @"https://www.youtube.com/embed/";
        
        ChromiumWebBrowser webBrowserYoutube;
        ChromiumWebBrowser webBrowserGG = null;
        public ucYoutube()
        {
            InitializeComponent();
        }
        private void ucYoutube_Load(object sender, EventArgs e)
        {
            tabGlobal.Appearance = TabAppearance.FlatButtons;
            tabGlobal.ItemSize = new Size(0, 1);
            tabGlobal.SizeMode = TabSizeMode.Fixed;
            listYoutube = new List<MediaFileInfo>();
            panelYoutube = new NonFlickerPannel();
            listButton = new List<MediaButton>();
            listLabel = new List<Label>();
            this.DoubleBuffered = true;
            this.tabdfVideo.Controls.Add(panelYoutube);
            panelYoutube.Dock = DockStyle.Fill;
            panelYoutube.BackgroundImageLayout = ImageLayout.Stretch;
            panelYoutube.BackgroundImage = Resources.bgYtb;
            Cef.Initialize(new CefSettings());
            backtodefaultButton.Visible = false;
            HideBackAndForward();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public static String GethtmlFromURL(string Url)
        {
            string html = httpClient.GetStringAsync(Url).Result;
            return html;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            if (searchText.Length > 30)
            {
                searchText = searchText.Substring(0, 30);
            }
            searchText = searchText.Replace("#", "%23");
            if (tabGlobal.SelectedIndex == 1 && isYoutubeGlobal)
            {
                string urlQuery = urlSearch + searchText;
                webBrowserYoutube.Load(urlQuery);
                return;
            }
            if (tabGlobal.SelectedIndex == 0 || tabGlobal.SelectedIndex == 1)
            {
                ClearAllData();
                string urlQuery = urlSearch + searchText;
                string html = GethtmlFromURL(urlQuery);
                var listCrawl = Regex.Matches(html, @"videoRenderer(.*?)watchEndpoint");
                foreach (var text in listCrawl)
                {
                    string s = text.ToString();
                    string thumbnailUrl = Regex.Matches(s, exThumbnail)[0].ToString();
                    thumbnailUrl = thumbnailUrl.Remove(0, 25);
                    thumbnailUrl = thumbnailUrl.Remove(thumbnailUrl.Length - 1, 1);
                    string title = Regex.Matches(s, exTitle)[0].ToString();
                    title = title.Remove(0, 26);
                    title = title.Remove(title.Length - 2, 2);
                    string Url = Regex.Matches(s, exUrl)[0].ToString();
                    Url = Url.Remove(0, 28);
                    Url = Url.Remove(Url.Length - 2, 2);
                    Url = urlYoutube + Url.Remove(0, 9);
                    MediaFileInfo info = new MediaFileInfo() { title = title, path = Url };
                    info.image = new MemoryStream(new WebClient().DownloadData(thumbnailUrl));
                    CreateButton(info);
                }
                RelocaYoutubeButton();
                StopAndBacktoDefault();
                return;
            }
            string urlGG = $"https://www.google.com/search?q={searchText}&hl=en&tbm=isch";
            if (webBrowserGG == null)
            {
                webBrowserGG = new ChromiumWebBrowser(urlGG) { Dock = DockStyle.Fill, };
                GC.Collect();
                tabGG.Controls.Add(webBrowserGG);
            }
            else
            {
                webBrowserGG.Load(urlGG);
            }

        }
        void vidClick(object sender, EventArgs e)
        {
            MediaButton a = sender as MediaButton;
            GC.Collect();
            string url = listYoutube[a.pos[0]].path;
            currentPos = a.pos[0];
            if (webBrowserYoutube != null)
            {
                webBrowserYoutube.Load(url);
            }
            else
            {
                webBrowserYoutube = new ChromiumWebBrowser(url) { Dock = DockStyle.Fill, };
                tabPlay.Controls.Add(webBrowserYoutube);
            }
            tabGlobal.SelectedIndex = 1;
            backtodefaultButton.Visible = true;
            backtodefaultButton.Image = Resources.undo_32px;
            HideBackAndForward(false);
            downloadmp3.Visible = true;
            downloadmp4.Visible = true;
            downloadLabel.Visible = false;
            isYoutubeGlobal = false;

        }

        public void CreateButton(MediaFileInfo info)
        {
            Label label = new Label();
            MediaButton btn = new MediaButton(countVideo, new Size(290, 180));
            info.pos[0] = countVideo;
            Image img;
            try
            {
                img = System.Drawing.Image.FromStream(info.image, true, true);
            }
            catch
            {
                img = Resources.music;
            }
            Image oldImage = img;
            img = ImageControl.FitImgToPictureBox(img, btn.Size);
            oldImage.Dispose();
            btn.Image = img;
            btn.Name = info.path;
            btn.Click += new EventHandler(this.vidClick);

            label.Text = info.title;
            label.AutoSize = false;
            label.BackColor = Color.BlueViolet;
            label.Font = new Font("Consolas", 12);
            label.Size = new Size(btn.Width, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            listYoutube.Add(info);
            listButton.Add(btn);
            listLabel.Add(label);
            panelYoutube.Controls.Add(btn);
            panelYoutube.Controls.Add(label);
            countVideo++;
        }

        public void RelocaYoutubeButton()
        {
            panelYoutubeOld = panelYoutube.Size;
            panelYoutube.Invalidate();
            if (countVideo == 0)
            {
                return;
            }
            int deltaW = 5000;
            int col_count = 1;
            int btnW = listButton[0].Width;
            int pnlW = panelYoutube.Width;
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
            panelYoutube.AutoScroll = false;
            for (int j = 0; j < countVideo; j++)
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
            panelYoutube.AutoScroll = true;
        }

        void ClearAllData()
        {
            for (int i = 0; i < countVideo; i++)
            {
                listButton[i].Dispose();
                listLabel[i].Dispose();
            }
            listButton.Clear();
            listLabel.Clear();
            listYoutube.Clear();
            countVideo = 0;
            GC.Collect();
        }

        public void StopAndBacktoDefault()
        {
            if (webBrowserYoutube != null)
            {
                webBrowserYoutube.Dispose();
                webBrowserYoutube = null;
            }
            tabGlobal.SelectedIndex = 0;
            isYoutubeGlobal = false;
            HideBackAndForward();
            GC.Collect();
        }
        private void backtodefaultButton_Click(object sender, EventArgs e)
        {
            if (tabGlobal.SelectedIndex == 1)
            {
                StopAndBacktoDefault();
                GC.Collect();
            }
            if (tabGlobal.SelectedIndex == 2)
            {
                tabGlobal.SelectedIndex = 0;
            }
            backtodefaultButton.Visible = false;
            downloadLabel.Visible = false;
            HideBackAndForward();

        }

        public void DfsDispose(Control u)
        {
            foreach (Control v in u.Controls)
                DfsDispose(v);
            u.Dispose();
        }


        private void ucYoutube_Paint(object sender, PaintEventArgs e)
        {
            if (panelYoutubeOld != panelYoutube.Size)
            {
                RelocaYoutubeButton();
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (tabGlobal.SelectedIndex == 1)
            {
                if (webBrowserYoutube != null)
                {
                    if (webBrowserYoutube.CanGoBack)
                    {
                        webBrowserYoutube.Back();
                    }
                }
                return;
            }
            if (tabGlobal.SelectedIndex == 2)
            {
                if (webBrowserGG != null)
                {
                    if (webBrowserGG.CanGoBack)
                    {
                        webBrowserGG.Back();
                    }
                }
                return;
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (tabGlobal.SelectedIndex == 1)
            {
                if (webBrowserYoutube != null)
                {
                    if (webBrowserYoutube.CanGoForward)
                    {
                        webBrowserYoutube.Forward();
                    }
                }
            }
            if (tabGlobal.SelectedIndex == 2)
            {
                if (webBrowserGG != null)
                {
                    if (webBrowserGG.CanGoForward)
                    {
                        webBrowserGG.Forward();
                    }
                }
            }
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            if (webBrowserYoutube != null)
            {
                webBrowserYoutube.Load(@"https:\\www.youtube.com");
            }
            else
            {
                webBrowserYoutube = new ChromiumWebBrowser(@"https:\\www.youtube.com") { Dock = DockStyle.Fill, };
            }
            GC.Collect();
            tabPlay.Controls.Add(webBrowserYoutube);
            tabGlobal.SelectedIndex = 1;
            backtodefaultButton.Visible = true;
            UnhideBackAndForward();
            downloadLabel.Visible = false;
            isYoutubeGlobal = true;
        }
        private void googleButton_Click(object sender, EventArgs e)
        {
            if (webBrowserGG == null)
            {
                webBrowserGG = new ChromiumWebBrowser(@"https://www.google.com/imghp?hl=en") { Dock = DockStyle.Fill, };
                GC.Collect();
                tabGG.Controls.Add(webBrowserGG);
            }    
            tabGlobal.SelectedIndex = 2;
            backtodefaultButton.Visible = true;
            UnhideBackAndForward();
            downloadLabel.Visible = false;
        }

        void HideBackAndForward(bool andDownloadBtn = true)
        {
            backButton.Visible = false;
            forwardButton.Visible = false;
            downloadLabel.Visible = false;
            if (andDownloadBtn)
            {
                downloadmp3.Visible = false;
                downloadmp4.Visible = false;
            }
        }

        void UnhideBackAndForward()
        {
            backButton.Visible = true;
            forwardButton.Visible = true;
        }

        private void downloadmp3_Click(object sender, EventArgs e)
        {
            downloadLabel.Visible = true;
            downloadLabel.Text = "Trạng thái tải";
            DownloadYoutube(true);
        }

        private void downloadmp4_Click(object sender, EventArgs e)
        {
            downloadLabel.Visible = true;
            downloadLabel.Text = "Trạng thái tải";
            DownloadYoutube();
        }

        string ReplaceSpecialChar(string s)
        {
            return s.Replace("*", "").Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("?", "").Replace("\"", "").Replace("|", "").Replace(">", "").Replace("<", "");
        }

        async void DownloadYoutube(bool isMp3 = false)
        {
            if (currentPos >= 0 && currentPos < countVideo)
            {
                using (FolderBrowserDialog form = new FolderBrowserDialog())
                {
                    form.Description = "Save to";
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        downloadLabel.Text = "Đang tải...";
                        try
                        {
                            YouTube yt = YouTube.Default;
                            var video = await yt.GetVideoAsync(listYoutube[currentPos].path);
                            string path = form.SelectedPath + "\\" + ReplaceSpecialChar(listYoutube[currentPos].title);
                            MediaFileInfo info = new MediaFileInfo();
                            info.image = listYoutube[currentPos].image;
                            info.title = listYoutube[currentPos].title;
                            if (isMp3)
                            {
                                File.WriteAllBytes(path, await video.GetBytesAsync());

                                var inp = new MediaToolkit.Model.MediaFile { Filename = path };
                                var outp = new MediaToolkit.Model.MediaFile { Filename = path + ".mp3" };

                                using (var en = new Engine())
                                {
                                    en.GetMetadata(inp);
                                    en.Convert(inp, outp);
                                }

                                using (TagLib.File tag = TagLib.File.Create(path + ".mp3"))
                                {
                                    tag.Tag.Title = info.title;
                                    tag.Tag.Pictures = new TagLib.IPicture[1]
                                    {
                                    new TagLib.Picture(new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter().ConvertTo(System.Drawing.Image.FromStream(info.image), typeof(byte[]))))
                                    };
                                    tag.Save();
                                }
                                info.artist = "unknow";
                                info.path = path + ".mp3";
                                info.fileName = Path.GetFileNameWithoutExtension(path + ".mp3");
                                Global.AudioYoutube.Add(info);
                                File.Delete(path);
                            }
                            else
                            {
                                path = path + ".mp4";
                                File.WriteAllBytes(path, await video.GetBytesAsync());
                                info.path = path;
                                Global.VideoYoutube.Add(info);
                            }

                            downloadLabel.Text = "Tải hoàn tất!";
                        }
                        catch
                        {
                            downloadLabel.Text = "Lỗi!";
                        }

                    }
                }
                GC.Collect();
            }
        }
    }

}

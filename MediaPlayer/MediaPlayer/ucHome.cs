using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolCustom;
using MediaPlayerCore;
using MediaPlayer.Properties;

namespace MediaPlayer
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            _Resize(this.Size);
        }

        readonly Size BUTTON_SIZE = new Size(200, 120);
        List<MediaButton> listFavMusic = new List<MediaButton>();
        List<Label> listFavMusicLabel = new List<Label>();
        List<MediaButton> listFavVideo = new List<MediaButton>();
        List<Label> listFavVideoLabel = new List<Label>();
        List<MediaButton> listFavImage = new List<MediaButton>();
        List<Label> listFavImageLabel = new List<Label>();
        Size SizeOld;
        public void _Resize(Size a)
        {
            panelTextphoto.Height = a.Height / 3;
            panelTextphoto.Location = new Point(0, 0);
            bckgrPhoto.Size = new Size(a.Width - panelTextphoto.Width, a.Height / 3);
            bckgrPhoto.Location = new Point(panelTextphoto.Width, 0);

            panelTextMusic.Height = a.Height / 3;
            panelTextMusic.Location = new Point(0, panelTextphoto.Height);
            bckgrMusic.Size = new Size(a.Width - panelTextMusic.Width, a.Height / 3);
            bckgrMusic.Location = new Point(panelTextMusic.Width, bckgrPhoto.Height);

            panelTextvideo.Height = a.Height / 3;
            panelTextvideo.Location = new Point(0, panelTextMusic.Height + panelTextphoto.Height);
            bckgrVideo.Size = new Size(a.Width - panelTextMusic.Width, a.Height / 3);
            bckgrVideo.Location = new Point(panelTextvideo.Width, bckgrPhoto.Height + bckgrMusic.Height);    
        }
        private void ucHome_Load(object sender, EventArgs e)
        {
            //not thing
        }
        public void UpdateFav()
        {
            bool flg = false; bool isHave;
            if (Global.isUpdateFavMusic == true)
            {
                for (int i = 0; i < listFavMusic.Count; i++)
                {
                    isHave = false;
                    for (int j = 0; j < Global.indexMusic.Count; j++)
                    {
                        if (Global.indexMusic[j].path == listFavMusic[i].Name && Global.indexMusic[i].isFav == true)
                        {
                            isHave = true;
                            break;
                        }
                    }
                    if (!isHave)
                    {
                        listFavMusic[i].DisposeButton();
                        listFavMusic.RemoveAt(i);
                        listFavMusicLabel[i].Dispose();
                        listFavMusicLabel.RemoveAt(i);
                        i--;
                    }
                }
                for (int i = 0; i < Global.indexMusic.Count; i++)
                {
                    if (Global.indexMusic[i].isFav == true)
                    {
                        flg = false;
                        for (int j = 0; j < listFavMusic.Count; j++)
                        {
                            if (listFavMusic[j].Name == Global.indexMusic[i].path)
                            {
                                listFavMusic[j].pos[0] = Global.indexMusic[i].pos[0];
                                flg = true;
                                break;
                            }
                        }
                        if (!flg)
                        {
                            MediaFileInfo music = Global.indexMusic[i];
                            //MediaButton btn = new MediaButton(i, new Size(200, 120));                  
                            MediaButton btn = CreatButton(music, music.pos[0], BUTTON_SIZE);
                            Label label = CreateLabel(music, btn.Size);
                            btn.Click += new EventHandler(this.musicClick);

                            listFavMusic.Add(btn);
                            listFavMusicLabel.Add(label);
                            bckgrMusic.Controls.Add(btn);
                            bckgrMusic.Controls.Add(label);
                        }
                    }
                }
                RelocaButton(listFavMusic, listFavMusicLabel, bckgrMusic);
            }
            if (Global.isUpdateFavVideo == true)
            {
                for (int i = 0; i < listFavVideo.Count; i++)
                {
                    isHave = false;
                    for (int j = 0; j < Global.indexVideo.Count; j++)
                    {
                        if (Global.indexVideo[j].path == listFavVideo[i].Name && Global.indexVideo[i].isFav == true)
                        {
                            isHave = true;
                            break;
                        }
                    }
                    if (!isHave)
                    {
                        listFavVideo[i].DisposeButton();
                        listFavVideo.RemoveAt(i);
                        listFavVideoLabel[i].Dispose();
                        listFavVideoLabel.RemoveAt(i);
                        i--;
                    }
                }
                for (int i = 0; i < Global.indexVideo.Count; i++)
                {
                    if (Global.indexVideo[i].isFav == true)
                    {
                        flg = false;
                        for (int j = 0; j < listFavVideo.Count; j++)
                        {
                            if (listFavVideo[j].Name == Global.indexVideo[i].path)
                            {
                                listFavVideo[j].pos[0] = Global.indexVideo[i].pos[0]; 
                                flg = true;
                                break;
                            }
                        }
                        if (!flg)
                        {
                            MediaFileInfo video = Global.indexVideo[i];
                            //MediaButton btn = new MediaButton(i, new Size(200, 120));
                            MediaButton btn = CreatButton(video, video.pos[0], BUTTON_SIZE);
                            Label label = CreateLabel(video, btn.Size);
                            btn.Click += new EventHandler(this.videoClick);

                            listFavVideo.Add(btn);
                            listFavVideoLabel.Add(label);
                            bckgrVideo.Controls.Add(btn);
                            bckgrVideo.Controls.Add(label);
                        }
                    }
                }
                RelocaButton(listFavVideo, listFavVideoLabel, bckgrVideo);
            }
            if (Global.isUpdateFavImage == true)
            {
                for (int i = 0; i < listFavImage.Count; i++)
                {
                    isHave = false;
                    for (int j = 0; j < Global.indexImage.Count; j++)
                    {
                        if (Global.indexImage[j].path == listFavImage[i].Name && Global.indexImage[i].isFav == true)
                        {
                            isHave = true;
                            break;
                        }
                    }
                    if (!isHave)
                    {
                        listFavImage[i].DisposeButton();
                        listFavImage.RemoveAt(i);
                        listFavImageLabel[i].Dispose();
                        listFavImageLabel.RemoveAt(i);
                        i--;
                    }
                }
                for (int i = 0; i < Global.indexImage.Count; i++)
                {
                    if (Global.indexImage[i].isFav == true)
                    {
                        flg = false;
                        for (int j = 0; j < listFavImage.Count; j++)
                        {
                            if (listFavImage[j].Name == Global.indexImage[i].path)
                            {
                                listFavImage[j].pos[0] = Global.indexImage[i].pos[0];
                                flg = true;
                                break;
                            }
                        }
                        if (!flg)
                        {
                            MediaFileInfo image = Global.indexImage[i];
                            //MediaButton btn = new MediaButton(i, new Size(200, 120));
                            MediaButton btn = CreatButton(image, image.pos[0], BUTTON_SIZE);
                            Label label = CreateLabel(image, btn.Size);
                            btn.Click += new EventHandler(this.imageClick);

                            listFavImage.Add(btn);
                            listFavImageLabel.Add(label);
                            bckgrPhoto.Controls.Add(btn);
                            bckgrPhoto.Controls.Add(label);
                        }
                    }
                }
                RelocaButton(listFavImage, listFavImageLabel, bckgrPhoto);
            }
        }
        private Label CreateLabel(MediaFileInfo info, Size sizebtn)
        {
            Label label = new Label();
            label.Text = info.title;
            label.AutoSize = false;
            label.BackColor = Color.BlueViolet;
            label.Font = new Font("Consolas", 12);
            label.Size = new Size(sizebtn.Width, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }
        private MediaButton CreatButton(MediaFileInfo info, int idx,  Size sizebtn)
        {
            MediaButton btn = new MediaButton(idx, sizebtn);
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
            return btn;
        }
        void musicClick(object sender, EventArgs e)
        {
            MediaButton a = sender as MediaButton;
            Parent.FindForm().Controls.Find("musicButton", true).OfType<Bunifu.UI.WinForms.BunifuImageButton>().FirstOrDefault().PerformClick();
            var form = Parent.FindForm().Controls.Find("ucMusic1", true).OfType<ucMusic>().FirstOrDefault();
            if (form != null)
            {
               //MessageBox.Show(a.pos[0].ToString());
                form.WantToPLayIndex(a.pos[0]);
            }
        }
        void videoClick(object sender, EventArgs e)
        {
            MediaButton a = sender as MediaButton;
            Parent.FindForm().Controls.Find("videoButton", true).OfType<Bunifu.UI.WinForms.BunifuImageButton>().FirstOrDefault().PerformClick();
            var form = Parent.FindForm().Controls.Find("ucVideo1", true).OfType<ucVideo>().FirstOrDefault();
            if (form != null)
            {
                form.WantToPLayIndex(a.pos[0]);
            }
        }
        void imageClick(object sender, EventArgs e)
        {
            MediaButton a = sender as MediaButton;
            Parent.FindForm().Controls.Find("pictureButton", true).OfType<Bunifu.UI.WinForms.BunifuImageButton>().FirstOrDefault().PerformClick();
            var form = Parent.FindForm().Controls.Find("ucPicture1", true).OfType<ucPicture>().FirstOrDefault();
            if (form != null)
            {
                form.WantToPLayIndex(a.pos[0]);
            }
        }
        private void RelocaButton(List<MediaButton> listBtn, List<Label> listLb, Panel pnl)
        {
            SizeOld = this.Size;
            int countMusic = listBtn.Count;
            if (countMusic == 0)
            {
                return;
            }
            int deltaW = 5000;
            int col_count = 1;
            int btnW = listBtn[0].Width;
            for (int j = 2; j <= 10; j++)
            {
                if ((pnl.Width - btnW - 32) / (j - 1) - btnW > 5)
                {
                    deltaW = Math.Min(deltaW, (bckgrMusic.Width - btnW - 32) / (j - 1) - btnW); 
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
            pnl.AutoScroll = false;
            for (int j = 0; j < countMusic; j++)
            {
                if (j == 0)
                {

                    listBtn[j].Location = new Point(3, 3);
                }
                else
                {
                    if (j % col_count == 0)
                    {
                        listBtn[j].Location = new Point(3, listBtn[j - 1].Location.Y + listBtn[j - 1].Height + listLb[j].Height + deltaW);
                    }
                    else
                    {
                        listBtn[j].Location = new Point(listBtn[j - 1].Location.X + listBtn[j - 1].Width + deltaW, listBtn[j - 1].Location.Y);
                    }

                }
                listLb[j].Location = new Point(listBtn[j].Location.X, listBtn[j].Location.Y + listBtn[j].Height);
            }
            pnl.AutoScroll = true;
        }

        private void ucHome_Paint(object sender, PaintEventArgs e)
        {
            if (SizeOld != this.Size)
            {
                _Resize(this.Size);
                RelocaButton(listFavMusic, listFavMusicLabel, bckgrMusic);
                RelocaButton(listFavVideo, listFavVideoLabel, bckgrVideo);
                RelocaButton(listFavImage, listFavImageLabel, bckgrPhoto);
            }
        }

    }
}

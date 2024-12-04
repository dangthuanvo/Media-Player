using MediaPlayerCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Properties;
using System.IO;
using System.Threading;
using VisioForge.Types.OutputFormat;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using MediaToolCustom;
using System.Media;

namespace MediaPlayer
{
    public partial class ucPicture : UserControl
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;
        int currentindex = 0;
        int countImage = 0;
        bool isdefault = false;
        string folderPath;
        List<MediaButton> listButton = new List<MediaButton>();
        List<Label> listLabel = new List<Label>();
        NonFlickerPannel panelImage = new NonFlickerPannel();
        System.Drawing.Size panelPictureOld;
        Image currentEditImage = null;
        SoundPlayer sound = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound5.wav");
        SoundPlayer sound2 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound6.wav");
        SoundPlayer sound3 = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + @"\Sound\sound7.wav");
        public ucPicture()
        {
            InitializeComponent();
            tab1Photo.Appearance = TabAppearance.FlatButtons;
            tab1Photo.ItemSize = new System.Drawing.Size(0, 1);
            tab1Photo.SizeMode = TabSizeMode.Fixed;
            Global.sizePanelPictureBox = panelDisplay.Size;
            backtodefaultButton.Visible = false;
            CropBtn.Visible = false;
            this.tabDefault.Controls.Add(panelImage);
            panelImage.Dock = DockStyle.Fill;
            panelImage.BackgroundImageLayout = ImageLayout.Stretch;
            panelImage.BackgroundImage = Resources.bgPic;
        }


        //Bật double buffer toàn uc, nhưng pannel có vẻ hơi lag
        //Xem bên máy khác có bị lag vậy không thì bật hàm này lên
        //3 uc control kia đều có hàm này.
        //pannel để chứa các button không được tạo bên design 
        //thêm lại ảnh nền bằng code 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public bool check(string ex)
        {
            for (int i = 0; i < Global.indexImage.Count(); i++)
            {
                if (Global.indexImage[i].path == ex)
                    return false;
            }
            return true;
        }
        private void addFolder_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listImage = new List<MediaFileInfo>();
            bool alr = true;
            List<string> exList = new List<string>() { "*.jpg", "*.png" };
            listImage = Import.ImportVideoFolder(ref folderPath, exList);
            foreach (MediaFileInfo img in listImage)
            {
                if (!check(img.path))
                {
                    MessageBox.Show(null, "Hình ảnh này đã được thêm trước đó!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(img);
                    Global.UpdateHistory(Global.currentusername, "đã thêm hình ảnh " + img.title + "!");
                }
            }
            RelocaImageButton(false);

            if (alr)
                Import.ShowMessageAddFileComplete("hình ảnh", listImage.Count());
            listImage.Clear();
        }
        private void addFile_Click(object sender, EventArgs e)
        {
            List<MediaFileInfo> listImage = new List<MediaFileInfo>();
            bool alr = true;
            string ex = "PNG|*.png|JPG|*.jpg";
            listImage = Import.ImportVideoFiles(ex);
            foreach (MediaFileInfo img in listImage)
            {
                if (!check(img.path))
                {
                    MessageBox.Show("Hình ảnh này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(img);
                    Global.UpdateHistory(Global.currentusername, "đã thêm hình ảnh " + img.title + "!");
                }
            }
            RelocaImageButton(false);
            if (alr)
                Import.ShowMessageAddFileComplete("hình ảnh", listImage.Count());
            listImage.Clear();
        }
        void TranfIMGIntoBox(string path)
        {
            Image img = Image.FromFile(path);
            Image oldimg = boxPicture.Image;
            ImageControl.CorrectExifOrientation(img);
            boxPicture.Size = ImageControl.GetNewSizeToFit(img.Size, panelDisplay.Size);
            Global.dfSize = boxPicture.Size;
            boxPicture.Image = img;
            boxPicture.Location = new System.Drawing.Point((panelDisplay.Size.Width - boxPicture.Size.Width) / 2, (panelDisplay.Size.Height - boxPicture.Size.Height) / 2);
            if (oldimg != null)
                oldimg.Dispose();
        }
        void imageClick(object sender, EventArgs e)
        {
            MediaButton a = sender as MediaButton;
            int pos = a.pos[0];
            if (!checkExists(Global.indexImage[pos].path, pos))
            {
                return;
            }
            tab1Photo.SelectedIndex = 1;
            TranfIMGIntoBox(a.Name);
            currentindex = pos;
            backtodefaultButton.Visible = true;
            backtodefaultButton.Image = Resources.undo_32px;
            isdefault = false;
            editting = false;
            CropBtn.Visible = true;
            if (!Global.isMute)
                sound.Play();
            //Parent.FindForm().Controls.Find("pictureButton", true).OfType<Bunifu.UI.WinForms.BunifuImageButton>().FirstOrDefault().PerformClick();

        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentindex == countImage - 1)
            {
                TranfIMGIntoBox(Global.indexImage[0].path);
                currentindex = 0;
            }
            else
            {
                TranfIMGIntoBox(Global.indexImage[currentindex + 1].path);
                currentindex++;
            }
        }
        private void priviousButton_Click(object sender, EventArgs e)
        {
            if (currentindex == 0)
            {
                TranfIMGIntoBox(Global.indexImage[countImage - 1].path);
                currentindex = countImage - 1;
            }
            else
            {
                TranfIMGIntoBox(Global.indexImage[currentindex - 1].path);
                currentindex--;
            }
        }
        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (boxPicture.Image != null)
            {
                Image oldImage = boxPicture.Image;
                Image newImage = ImageControl.RotateImage(oldImage);
                boxPicture.Size = ImageControl.GetNewSizeToFit(newImage.Size, panelDisplay.Size);
                Global.dfSize = boxPicture.Size;
                boxPicture.Image = newImage;
                boxPicture.Location = new System.Drawing.Point((panelDisplay.Size.Width - boxPicture.Size.Width) / 2, (panelDisplay.Size.Height - boxPicture.Size.Height) / 2);
                oldImage.Dispose();
            }
        }

        void delClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            if (pos == currentindex)
            {
                currentindex = 0;
                backtodefaultButton.Visible = false;
            }
            Global.UpdateHistory(Global.currentusername, "đã xoá hình ảnh " + Global.indexImage[pos].title + "!");
            if (Global.indexImage[pos].isFav == true)
            {
                Global.isUpdateFavImage = true;
            }
            if (pos == currentindex)
                currentindex = 0;
            else
                if (pos < currentindex)
                currentindex--;
            Global.indexImage.RemoveAt(pos);
            listButton[pos].DisposeButton();
            listLabel[pos].Dispose();
            listLabel.RemoveAt(pos);
            listButton.RemoveAt(pos);
            countImage--;
            for (int i = pos; i < countImage; i++)
            {
                listButton[i].pos[0] = i;
                Global.indexImage[i].pos[0] = i;
            }
            RelocaImageButton();
            if (!Global.isMute)
                sound3.Play();
        }
        void favClick(object sender, EventArgs e)
        {
            ButtonFavEra a = sender as ButtonFavEra;
            int pos = a.pos[0];
            if (!checkExists(Global.indexImage[pos].path, pos))
            {
                return;
            }
            if (!Global.indexImage[pos].isFav)
            {
                a.Image = Resources.fav;
                Global.indexImage[pos].isFav = true;
                Global.UpdateHistory(Global.currentusername, "đã yêu thích hình ảnh " + Global.indexImage[pos].title + "!");
                if (!Global.isMute)
                    sound2.Play();
            }
            else
            {
                a.Image = Resources.preheart2;
                Global.indexImage[pos].isFav = false;
                Global.UpdateHistory(Global.currentusername, "đã bỏ yêu thích hình ảnh " + Global.indexImage[pos].title + "!");
            }
            Global.isUpdateFavImage = true;
        }
        private void captureButton_Click(object sender, EventArgs e)
        {
            tab1Photo.SelectedIndex = 2;
            editting = false;
            CropBtn.Image = Resources.edit_32px;
            CropBtn.Visible = false;
        }
        string globalpath = "";
        private void startButton_Click(object sender, EventArgs e)
        {
            string ex = "jpg|*.jpg";
            string path = null;
            path = Import.SaveMedia(ex);
            if (!String.IsNullOrEmpty(path))
            {
                isCameraRunning = true;
                globalpath = path;
                CaptureCamera();
            }

        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            Bitmap snapshot = new Bitmap(boxCapture.Image);
            snapshot.Save(globalpath, ImageFormat.Jpeg);
            isCameraRunning = false;
            capture.Release();
            List<string> a = new List<string>();
            a.Add(globalpath);
            CreateButton(Import.GetListVideoFromFilePaths(a)[0]);
            RelocaImageButton(false);
            //indexcheckFav.Add(false);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            tab1Photo.SelectedIndex = 0;
        }
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (boxCapture.Image != null)
                    {
                        boxCapture.Image.Dispose();
                    }
                    boxCapture.Image = image;
                    //if (!flag)
                    //{
                    //    flag = !flag;
                    boxCapture.Location = new System.Drawing.Point((tabCapture.Size.Width - boxCapture.Size.Width) / 2, (tabCapture.Size.Height - boxCapture.Size.Height) / 2);
                    boxCapture.Size = ImageControl.GetNewSizeToFit(image.Size, tabCapture.Size);
                    //}
                }
            }
        }

        private void backtodefaultButton_Click(object sender, EventArgs e)
        {
            if (tab1Photo.SelectedIndex == 3)
            {
                tab1Photo.SelectedIndex = 1;
                CropBtn.Visible = true;
                editting = false;
                CropBtn.Image = Resources.edit_32px;
                //CropBtn.Visible = false;
                return;
            }
            if (!isdefault)
            {
                CropBtn.Visible = false;
                tab1Photo.SelectedIndex = 0;
                isdefault = true;
                backtodefaultButton.Image = Resources.deundo;
            }
            else
            {
                tab1Photo.SelectedIndex = 1;
                isdefault = false;
                backtodefaultButton.Image = Resources.undo_32px;
            }
        }

        public void CreateButton(MediaFileInfo Image)
        {
            Label label = new Label();
            MediaButton btn = new MediaButton(countImage);
            Image.pos[0] = countImage;
            Image img;
            try
            {
                img = System.Drawing.Image.FromStream(Image.image, true, true);
            }
            catch
            {
                img = Resources.music;
            }
            Image oldImage = img;
            img = ImageControl.FitImgToPictureBox(img, btn.Size);
            oldImage.Dispose();
            btn.Image = img;
            btn.Name = Image.path;
            btn.Click += new EventHandler(this.imageClick);
            btn.fav.Click += new EventHandler(this.favClick);
            btn.era.Click += new EventHandler(this.delClick);
            if (Image.isFav == true)
            {
                btn.fav.Image = Resources.fav;
                Global.isUpdateFavImage = true;
            }

            label.Text = Image.title;
            label.AutoSize = false;
            label.BackColor = Color.BlueViolet;
            label.Font = new Font("Consolas", 12);
            label.Size = new System.Drawing.Size(btn.Width, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            Global.indexImage.Add(Image);
            listButton.Add(btn);
            listLabel.Add(label);
            panelImage.Controls.Add(btn);
            panelImage.Controls.Add(label);

            countImage++;
        }
        public void RelocaImageButton(bool checkVisible = true)
        {
            panelPictureOld = panelImage.Size;
            if (!checkVisible)
            {
                bunifuTextBox1.Text = "";
            }
            panelImage.Invalidate();
            if (countImage == 0)
            {
                return;
            }
            int deltaW = 5000;
            int col_count = 1;
            int btnW = listButton[0].Width;
            int pnlW = panelImage.Width;
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
            panelImage.AutoScroll = false;
            for (int j = 0; j < countImage; j++)
            {
                if (listButton[j].Visible == true || !checkVisible)
                {
                    if (i == 0)
                    {
                        listButton[j].Location = new System.Drawing.Point(7, 3);
                    }
                    else
                    {
                        if (i % col_count == 0)
                        {
                            listButton[j].Location = new System.Drawing.Point(7, listButton[old_i].Location.Y + listButton[old_i].Height + listLabel[j].Height + deltaW);
                        }
                        else
                        {
                            listButton[j].Location = new System.Drawing.Point(listButton[old_i].Location.X + listButton[old_i].Width + deltaW, listButton[old_i].Location.Y);
                        }
                    }
                    listLabel[j].Location = new System.Drawing.Point(listButton[j].Location.X, listButton[j].Location.Y + listButton[j].Height);
                    old_i = j;
                    i++;
                }
            }
            panelImage.AutoScroll = true;
        }
        public void WantToPLayIndex(int idx)
        {
            if (!isdefault)
            {
                this.backtodefaultButton.PerformClick();
            }
            listButton[idx].PerformClick();
        }
        public void CreateButtonWithUserData()
        {
            if (!Global.isNonUser)
            {
                List<bool> Fav = new List<bool>();
                List<MediaFileInfo> listImage = new List<MediaFileInfo>();
                List<string> lines = new List<string>();
                int count;
                Global.GetPathsinData(Global.currentphotopath, ref Fav, ref lines);
                listImage = Import.GetListVideoFromFilePaths(new List<string>(lines));
                count = listImage.Count();
                for (int i = 0; i < count; i++)
                {
                    listImage[i].isFav = (Fav[i]) ? true : false;
                }
                foreach (MediaFileInfo Image in listImage)
                {
                    if (check(Image.path))
                    {
                        Image.pos[0] = countImage;

                        CreateButton(Image);
                    }
                }
                RelocaImageButton(false);
                Fav.Clear();
                listImage.Clear();
                lines.Clear();
            }
        }
        public void CreateButtonWithDragnDropItemList(List<string> a)
        {
            List<MediaFileInfo> listPhoto = new List<MediaFileInfo>();
            listPhoto = Import.GetListVideoFromFilePaths(a);
            bool alr = true;
            foreach (MediaFileInfo music in listPhoto)
            {
                if (!check(music.path))
                {
                    MessageBox.Show("Hình ảnh này đã được thêm trước đó!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alr = false;
                }
                else
                {
                    CreateButton(music);
                    Global.UpdateHistory(Global.currentusername, "đã thêm hình ảnh " + music.title + "!");
                }
            }
            RelocaImageButton(false);
            if (alr)
            {
                Import.ShowMessageAddFileComplete("hình ảnh", listPhoto.Count());
            }
            listPhoto.Clear();
        }
        public void DeleteAllData()
        {
            while (countImage > 0)
            {
                listButton[0].era.PerformClick();
            }
        }

        private void ucPicture_Paint(object sender, PaintEventArgs e)
        {
            if (panelPictureOld != panelImage.Size)
            {
                RelocaImageButton();
            }
        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                for (int i = 0; i < countImage; i++)
                {
                    listButton[i].Visible = true;
                    listLabel[i].Visible = true;
                }
                RelocaImageButton();
                return;
            }
            for (int i = 0; i < countImage; i++)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Global.indexImage[i].title, bunifuTextBox1.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
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
            RelocaImageButton();
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
        private void flipButton_Click(object sender, EventArgs e)
        {
            if (boxPicture.Image != null)
            {
                Image oldImage = boxPicture.Image;
                Image newImage = ImageControl.FlipImage(oldImage);
                boxPicture.Size = ImageControl.GetNewSizeToFit(newImage.Size, panelDisplay.Size);
                boxPicture.Image = newImage;
                boxPicture.Location = new System.Drawing.Point((panelDisplay.Size.Width - boxPicture.Size.Width) / 2, (panelDisplay.Size.Height - boxPicture.Size.Height) / 2);
                oldImage.Dispose();
            }
        }
        public string ReplaceSpecialChar(string s)
        {
            return s.Replace("*", "").Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("?", "").Replace("\"", "").Replace("|", "").Replace(">", "").Replace("<", "");
        }
        bool editting = false;
        private void CropBtn_Click(object sender, EventArgs e)
        {
            if (editting == false)
            {
                CropBtn.Image = Resources.save_24px;
                //Set mode custom khi crop ảnh 
                cropPicturePnl.SelectionInitialMode = CropPictureBox.CropBoxSelectionInitialMode.Custom;
                //Thêm ảnh vào cropPanel
                Image img = cropPicturePnl.Image;
                Image currentImg = Image.FromFile(Global.indexImage[currentindex].path);
                cropPicturePnl.Image = currentImg;
                tab1Photo.SelectedIndex = 3;
                if (currentEditImage != null)
                {
                    currentEditImage.Dispose();
                }
                currentEditImage = currentImg;
                if (img != null)
                {
                    img.Dispose();
                }
                editting = true;
            }
            else
            {
                //Nếu không đang edit thì lưu ảnh.
                if (currentEditImage != null)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        string path;
                        sfd.InitialDirectory = @"D:\";
                        sfd.DefaultExt = "*";
                        sfd.Filter = "PNG|*.png|JPG|*.jpg";
                        string tmp = Path.GetExtension(Global.indexImage[currentindex].path);
                        tmp = tmp.Remove(tmp.IndexOf('.'), 1);
                        //Tạo tên gợi ý 
                        sfd.FileName = Global.indexImage[currentindex].title + "-Cropped";
                        //Tìm xem ảnh gốc dạng đuôi nào thì set ảnh được crop dạng file đó
                        if (Path.GetExtension(Global.indexImage[currentindex].path).ToLower() == ".jpg")
                        {
                            sfd.FilterIndex = 2;
                        }
                        else
                        {
                            sfd.FilterIndex = 1;
                        }
                        string tmpname = ReplaceSpecialChar(Global.indexImage[currentindex].title) + "-Cropped";
                        int index = 1;
                        while (File.Exists(sfd.InitialDirectory + tmpname + '.' + tmp))
                        {
                            tmpname = ReplaceSpecialChar(Global.indexImage[currentindex].title) + "-Cropped" + $"({index++})";
                        }
                        sfd.FileName = tmpname;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            path = sfd.FileName;
                            currentEditImage.Save(path);
                            //Add thêm ảnh vào danh sách hiện hành
                            CreateButton(Import.GetListVideoFromFilePaths(new List<string>() { path })[0]);
                            RelocaImageButton(false);
                        }
                    }
                }
            }
        }
        private void CustomModebtn_Click(object sender, EventArgs e)
        {
            cropPicturePnl.SelectionInitialMode = CropPictureBox.CropBoxSelectionInitialMode.Custom;
        }

        private void SquareModeBtn_Click(object sender, EventArgs e)
        {
            cropPicturePnl.SelectionInitialMode = CropPictureBox.CropBoxSelectionInitialMode.Square;
        }

        private void Size34ModeBtn_Click(object sender, EventArgs e)
        {
            cropPicturePnl.SelectionInitialMode = CropPictureBox.CropBoxSelectionInitialMode.Size3x4;
        }

        private void CropImagebtn_Click(object sender, EventArgs e)
        {
            Image croppedImage = cropPicturePnl.GetCroppedImage();
            if (croppedImage != null)
            {

                Image img = cropPicturePnl.Image;
                cropPicturePnl.Image = croppedImage;
                currentEditImage = croppedImage;
                if (img != null)
                {
                    img.Dispose();
                }

            }
        }
    }
}

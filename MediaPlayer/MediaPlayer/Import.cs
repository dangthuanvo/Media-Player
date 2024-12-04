using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MediaPlayerCore;
using System.Windows.Shell;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack;
using System.Drawing;
using WMPLib;
using NAudio.Wave;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaPlayer
{
    static public class Import
    {
        static public string ReplaceSpecialChar(string s)
        {
            return s.Replace("*", "").Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("?", "").Replace("\"", "").Replace("|", "").Replace(">", "").Replace("<", "");
        }
        static public string SaveMedia(string ex)
        {
            string s = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = @"C:\";
                //sfd.CheckFileExists = true;
                //sfd.CheckPathExists = true;
                sfd.DefaultExt = "*";
                sfd.Filter = ex;
                if (sfd.ShowDialog() == DialogResult.OK)
                    s = sfd.FileName;
            }
            return s;
        }
        static public string SaveMediaProForVideo(string path, int n)
        {
            string s = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = @"D:\";
                string tmp = Path.GetExtension(path);
                tmp = tmp.Remove(tmp.IndexOf('.'), 1);
                sfd.Filter = tmp + "|*." + tmp;
                sfd.DefaultExt = "*";
                string tmpname = ReplaceSpecialChar(Global.indexVideo[n].title) + "-Trimmed";
                int index = 1;
                while (File.Exists(sfd.InitialDirectory + tmpname + '.' + tmp))
                {
                    tmpname = ReplaceSpecialChar(Global.indexVideo[n].title) + "-Trimmed" + $"({index++})";
                }
                sfd.FileName = tmpname;
                if (sfd.ShowDialog() == DialogResult.OK)
                    s = sfd.FileName;
            }
            return s;
        }
        static public string SaveMediaProForAudio(string path, int n)
        {
            string s = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = @"D:\";
                string tmp = Path.GetExtension(path);
                tmp = tmp.Remove(tmp.IndexOf('.'), 1);
                sfd.Filter = tmp + "|*." + tmp;
                sfd.DefaultExt = "*";
                string tmpname = ReplaceSpecialChar(Global.indexMusic[n].title) + "-Trimmed";
                int index = 1;
                while (File.Exists(sfd.InitialDirectory + tmpname + '.' + tmp))
                {
                    tmpname = ReplaceSpecialChar(Global.indexMusic[n].title) + "-Trimmed" + $"({index++})";
                }
                sfd.FileName = tmpname;
                if (sfd.ShowDialog() == DialogResult.OK)
                    s = sfd.FileName;
            }
            return s;
        }
        static public List<MediaFileInfo> ImportMusicFolder(ref string folderPath, List<string> extensions)
        {
            string[] Paths;
            List<string> listPaths = new List<string>();
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath.ToString();
                    foreach (string ex in extensions)
                    {
                        Paths = Directory.GetFiles(fbd.SelectedPath, ex);
                        foreach (string path in Paths)
                        {
                            if (File.Exists(path))
                            {
                                listPaths.Add(path);
                            }
                        }
                    }
                    if (listPaths != null)
                    {
                        list = GetListMusicFromFilePaths(listPaths);
                    }
                }
            }
            return list;
        }
        static public List<MediaFileInfo> ImportMusicFiles(string extensions)
        {
            string[] exlist = extensions.Replace("*", "").Split('|');
            string exall = @"All Types|";
            for (int i = 1; i < exlist.Length; i += 2)
            {
                exall = exall + @"*" + exlist[i].ToLower() + ((i < exlist.Count() - 1) ? ";" : "");
            }
            string extensions2 = exall + @"|" + extensions + "|*|*.*";
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = extensions2 })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileNames != null)
                    {
                        List<string> listPaths = new List<string>();
                        foreach (string path in ofd.FileNames.ToList())
                        {
                            string exFile = Path.GetExtension(path);
                            for (int i = 1; i < exlist.Length; i += 2)
                            {
                                if (exFile.ToLower() == exlist[i].ToLower() && File.Exists(path))
                                {
                                    listPaths.Add(path);
                                }
                            }
                        }
                        list = GetListMusicFromFilePaths(listPaths);
                    }
                }
            }
            return list;
        }

        static public List<MediaFileInfo> GetListMusicFromFolderPaths(string folderPath, List<string> extensions)
        {
            string[] Paths;
            List<string> listPaths = new List<string>();
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            foreach (string ex in extensions)
            {
                Paths = Directory.GetFiles(folderPath, ex);
                foreach (string path in Paths)
                {
                    if (File.Exists(path))
                    {
                        listPaths.Add(path);
                    }
                }
            }
            if (listPaths != null)
            {
                list = GetListMusicFromFilePaths(listPaths);
            }
            return list;
        }
        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }
        static public List<MediaFileInfo> GetListMusicFromFilePaths(List<string> listPaths)
        {
            List<MediaFileInfo> listFile = new List<MediaFileInfo>();
            foreach (string path in listPaths)
            {
                FileInfo fi = new FileInfo(path);
                TagLib.File tagFile = TagLib.File.Create(fi.FullName);
                //WindowsMediaPlayer player = new WindowsMediaPlayer();
                //IWMPMedia audioInfo = player.newMedia(fi.FullName);
                string pathfi = fi.FullName;
                string artist = "unknown";
                if (tagFile.Tag.FirstAlbumArtist != null)
                    artist = tagFile.Tag.FirstAlbumArtist;
                string album = tagFile.Tag.Album;
                string title = tagFile.Tag.Title;
                string genre = tagFile.Tag.FirstGenre;
                string fileName = Path.GetFileNameWithoutExtension(fi.FullName);
                int bitrate = tagFile.Properties.AudioBitrate;
                //TimeSpan duration = TimeSpan.FromSeconds((int)(new Mp3FileReader(fi.FullName).TotalTime.TotalSeconds));
                TimeSpan duration = TimeSpan.FromSeconds((int)(GetVideoDuration(fi.FullName).TotalSeconds));
                MemoryStream ms = new MemoryStream();
                if (string.IsNullOrEmpty(title))
                {
                    title = Path.GetFileNameWithoutExtension(fi.FullName);
                }
                try
                {
                    ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
                }
                catch
                {
                }
                listFile.Add(new MediaFileInfo() { title = title, path = pathfi, artist = artist, album = album, genre = genre, bitrate = bitrate, duration = duration, image = ms, fileName = fileName });
            }
            return listFile;
        }
        static public List<MediaFileInfo> ImportVideoFolder(ref string folderPath, List<string> extensions)
        {
            string[] Paths;
            List<string> listPaths = new List<string>();
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath.ToString();
                    foreach (string ex in extensions)
                    {
                        Paths = Directory.GetFiles(fbd.SelectedPath, ex);
                        foreach (string path in Paths)
                        {
                            if (File.Exists(path))
                            {
                                listPaths.Add(path);
                            }
                        }
                    }
                    if (listPaths != null)
                    {
                        list = GetListVideoFromFilePaths(listPaths);
                    }
                }
            }
            return list;
        }
        static public List<MediaFileInfo> ImportVideoFiles(string extensions)
        {
            string[] exlist = extensions.Replace("*", "").Split('|');
            string exall = @"All Types|";
            for (int i = 1; i < exlist.Length; i += 2)
            {
                exall = exall + @"*" + exlist[i].ToLower() + ((i < exlist.Count() - 1) ? ";" : "");
            }
            string extensions2 = exall + @"|" + extensions + "|*|*.*";
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = extensions2 })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileNames != null)
                    {
                        List<string> listPaths = new List<string>();
                        foreach (string path in ofd.FileNames.ToList())
                        {
                            string exFile = Path.GetExtension(path);
                            //MessageBox.Show(exFile);
                            for (int i = 1; i < exlist.Length; i += 2)
                            {
                                if (exFile.ToLower() == exlist[i].ToLower() && File.Exists(path))
                                {
                                    //MessageBox.Show(path);
                                    listPaths.Add(path);
                                }
                            }
                        }
                        list = GetListVideoFromFilePaths(listPaths);
                    }
                }
            }
            return list;
        }
        static public List<MediaFileInfo> GetListVideoFromFolderPaths(string folderPath, List<string> extensions)
        {
            string[] Paths;
            List<string> listPaths = new List<string>();
            List<MediaFileInfo> list = new List<MediaFileInfo>();
            foreach (string ex in extensions)
            {
                Paths = Directory.GetFiles(folderPath, ex);
                foreach (string path in Paths)
                {
                    if (File.Exists(path))
                    {
                        listPaths.Add(path);
                    }
                }
            }
            if (listPaths != null)
            {
                list = GetListVideoFromFilePaths(listPaths);
            }
            return list;
        }
        static public List<MediaFileInfo> GetListVideoFromFilePaths(List<string> listPaths)
        {
            List<MediaFileInfo> listFile = new List<MediaFileInfo>();
            foreach (string path in listPaths)
            {
                FileInfo fi = new FileInfo(path);
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                IWMPMedia videoInfo = player.newMedia(path);

                string pathfi = fi.FullName;
                TimeSpan duration = TimeSpan.FromSeconds(videoInfo.duration);
                MemoryStream ms = new MemoryStream();
                string title = Path.GetFileNameWithoutExtension(fi.FullName);
                try
                {
                    ShellFile shellFile = ShellFile.FromFilePath(fi.FullName);
                    Bitmap bitmap = shellFile.Thumbnail.Bitmap;
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    shellFile.Dispose();
                }
                catch
                {

                }
                listFile.Add(new MediaFileInfo() { title = title, path = pathfi, duration = duration, image = ms });
                GC.Collect();
            }
            return listFile;
        }
        static public void ShowMessageAddFileComplete(string type, int count)
        {
            string e;
            if (count == 0)
            {
                e = "Không có " + type + ".";
            }
            else
            {
                e = "Đã thêm " + count.ToString() + " " + type + "!";
            }
            MessageBox.Show(e, "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public List<Artist> AddMusicIntoArtist(List<MediaFileInfo> listMusic)
        {
            List<Artist> listArtist = new List<Artist>();
            foreach (MediaFileInfo music in listMusic)
            {
                foreach (Artist artist in listArtist)
                {
                    if (artist.name == music.artist)
                    {
                        artist.Add(music);
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(music.artist))
                {
                    Artist artist = new Artist();
                    artist.name = music.artist;
                    artist.Add(music);
                    listArtist.Add(artist);
                }
                else
                {
                    //donotthing
                }
            }
            return listArtist;
        }
        static public List<Album> AddMusicIntoAlbum(List<MediaFileInfo> listMusic)
        {
            List<Album> listAlbums = new List<Album>();
            foreach (MediaFileInfo music in listMusic)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.albumName == music.album)
                    {
                        album.Add(music);
                        break;
                        //return;
                    }
                }
                if (!string.IsNullOrEmpty(music.album))
                {
                    Album album = new Album();
                    album.albumName = music.album;
                    album.Add(music);
                    listAlbums.Add(album);
                }
                else
                {
                    //donotthing
                }
            }
            return listAlbums;
        }
    }
}

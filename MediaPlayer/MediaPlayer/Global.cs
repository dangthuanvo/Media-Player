using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayerCore;

namespace MediaPlayer
{
    public static class Global
    {
        //public static string a = System.IO.Directory.GetCurrentDirectory(); 
        public static bool isMute;
        public static string historypath;
        public static string settingpath;
        public static bool isDark;
        public static bool haveIntro;
        public static string currentpath;
        public static string currentusername;
        public static string currentpassword;
        public static string currentlastname;
        public static string currentmusicpath;
        public static string currentvideopath;
        public static string currentphotopath;
        public static string currenthistorypath;
        public static bool isNonUser = false;
        public static List<MediaFileInfo> indexMusic = new List<MediaFileInfo>();
        public static bool isUpdateFavMusic;
        public static List<MediaFileInfo> AudioYoutube = new List<MediaFileInfo>();

        public static List<MediaFileInfo> indexVideo = new List<MediaFileInfo>();
        public static bool isUpdateFavVideo;
        public static List<MediaFileInfo> VideoYoutube = new List<MediaFileInfo>();

        public static List<MediaFileInfo> indexImage = new List<MediaFileInfo>();
        public static bool isUpdateFavImage;

        static public Size sizePanelPictureBox;
        public static Size dfSize;
        public static int GetWid(TabPage a)
        {
            return a.Width;
        }
        public static int GetHei(TabPage a)
        {
            return a.Height;
        }
        public static int GetWid(PictureBox a)
        {
            return a.Width;
        }
        public static int GetHei(PictureBox a)
        {
            return a.Height;
        }
        public static void GetPathsinData(string pathFile, ref List<bool> Fav, ref List<string> lines)
        {
            Fav.Clear();
            lines.Clear();
            lines = new List<string>(File.ReadAllLines(pathFile));
            int count = lines.Count();
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count; i++)
            {
                string path = lines[i].Replace("*", "");
                if (File.Exists(path))
                {
                    if (lines[i][0] == '*')
                    {
                        Fav.Add(true);
                        lines[i] = path;
                    }
                    else
                    {
                        Fav.Add(false);
                    }
                }
                else
                {
                    lines.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }
        public static void UpdateHistory(string a, string b)
        {
            using (StreamWriter writetext = new StreamWriter(Global.historypath, true))
            {
                DateTime now = DateTime.Now;
                if(!isNonUser)
                    writetext.Write(now.ToString() + ": user " + a + " " + b + "\n");
                else
                    writetext.Write(now.ToString() + ": " + a + " " + b + "\n");
            }
            if (!isNonUser)
            {
                try
                {
                    using (StreamWriter writetext = new StreamWriter(Global.currenthistorypath, true))
                    {
                        DateTime now = DateTime.Now;
                        writetext.Write(now.ToString() + ": user " + a + " " + b + "\n");
                    }
                }
                catch { }
            }
        }
        public static void UpdateDataUser()
        {
            using (StreamWriter writetext = new StreamWriter(currentmusicpath))
            {
                foreach (MediaFileInfo p in indexMusic)
                {
                    if (p.isFav)
                    {
                        writetext.WriteLine("*" + p.path);
                    }
                    else
                    {
                        writetext.WriteLine(p.path);
                    }
                }
            }
            using (StreamWriter writetext = new StreamWriter(currentvideopath))
            {
                foreach (MediaFileInfo p in indexVideo)
                {
                    if (p.isFav)
                    {
                        writetext.WriteLine("*" + p.path);
                    }
                    else
                    {
                        writetext.WriteLine(p.path);
                    }
                }
            }
            using (StreamWriter writetext = new StreamWriter(currentphotopath))
            {
                foreach (MediaFileInfo p in indexImage)
                {
                    if (p.isFav)
                    {
                        writetext.WriteLine("*" + p.path);
                    }
                    else
                    {
                        writetext.WriteLine(p.path);
                    }
                }
            }
        }
    }
}

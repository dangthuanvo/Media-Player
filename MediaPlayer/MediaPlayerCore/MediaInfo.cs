 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MediaPlayerCore
{
    public class MediaFileInfo
    {
        public bool isFav { get; set; } 
        public string path { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string fileName { get; set; }
        public int bitrate { get; set; }
        public TimeSpan duration { get; set; }
        public MemoryStream image { get; set; }
        public int[] pos { get; set; }
        public MediaFileInfo()
        {
            isFav = false;
            pos = new int[1];
        }

    }
}


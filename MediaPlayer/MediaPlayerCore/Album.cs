using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerCore
{
    public class Album
    {
        public string albumName { get; set; }
        public List<MediaFileInfo> listMusic { get; set; }
        public Artist artist { get; set; }
        MemoryStream image { get; set; }
        public int MusicCount
        {
            get
            {
                return listMusic.Count;
            }
        }
        public Album()
        {
            listMusic = new List<MediaFileInfo>();
            albumName = "";
            image = null;
        }
        public void Add(MediaFileInfo music)
        {
            if (albumName == "")
            {
                albumName = music.album;
            }
            if (image == null)
            {
                image = music.image;
            }
            listMusic.Add(music);
        }
    }
}

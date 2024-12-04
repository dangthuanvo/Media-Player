using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerCore
{
    public class Artist
    {
        public string name { get; set; }
        public List<Album> albums { get; set; }
        public List<MediaFileInfo> otherMusics { get; set; } //no album

        public Artist()
        {
            name = "";
            albums = new List<Album>();
            otherMusics = new List<MediaFileInfo>();

        }
        public void Add(MediaFileInfo music)
        {
            foreach (Album a in albums)
            {
                if (a.albumName == music.album)
                {
                    a.Add(music);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(music.album))
            {
                Album album = new Album();
                album.albumName = music.album;
                album.artist = this;
                album.Add(music);
                albums.Add(album);
            }
            else
            {
                otherMusics.Add(music);
            }
        }
    }
}

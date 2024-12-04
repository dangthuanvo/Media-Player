using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class MediaFile
    {
        private string name;
        private string path;
        public MediaFile(string u = "", string p = "")
        {
            name = u;
            path = p;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}

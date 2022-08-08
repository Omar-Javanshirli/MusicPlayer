using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MusicModels
{
    internal class MusicAbout
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string SongName { get; set; }
        public int MusicReyting { get; set; }
    }
}

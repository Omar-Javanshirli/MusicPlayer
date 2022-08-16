using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Views
{
    internal interface ISingerView
    {
        string Image { get; set; }
        string SingerName { get; set; }
        string SongName { get; set; }
    }
}

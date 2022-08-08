using MusicPlayer.MusicModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MusicView
{
    internal interface IMainMusicView
    {
        Image image { get; set; }
        string IdLbl { get; set; }
        string SongNameLbl { get; set; }
        EventHandler<EventArgs> ForYouButtonClik { get; set; }
    }
}

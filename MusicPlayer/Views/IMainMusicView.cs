using MusicPlayer.MusicModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MusicView
{
    public interface IMainMusicView
    {
        string Image { get; set; }
        string IdLbl { get; set; }
        string SongNameLbl { get; set; }

        EventHandler<EventArgs> ForYouButtonClik { get; set; }
    }
}

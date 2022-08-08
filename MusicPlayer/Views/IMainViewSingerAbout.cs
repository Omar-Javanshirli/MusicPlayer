using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.ViewsSingerPhoto
{
    public interface IMainViewSingerAbout
    {
        EventHandler<EventArgs> SearchButton { get; set; }
    }
}

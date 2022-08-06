using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.ViewsSingerPhoto
{
    internal interface IMainViewSingerAbout
    {
        Image SingerPhoto1 { get; set; }
        Image SingerPhoto2 { get; set; }
        Image SingerPhoto3 { get; set; }  
        Image SingerPhoto4 { get; set; }
        EventHandler<EventArgs> SearchButton { get; set; }
        string SearchText { get; set; }
    }
}

using Guna.UI2.WinForms;
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
        EventHandler<EventArgs> MouseEnterEvent { get; set; }
        Guna2TextBox Searchtext { get; set; }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Views
{
    internal interface IPhotoAndAlbumName
    {
        string Image { get; set; }  
        string SingerName { get; set; }
        string AlbumName { get; set; }
        Guna.UI2.WinForms.Guna2PictureBox SingerPhoto { get; set; }
        EventHandler<EventArgs> NextButtonClick { get; set; }
        EventHandler<EventArgs> PrevButtonClick { get; set; }
        EventHandler<EventArgs> Timer_Tick { get; set; }
        EventHandler<EventArgs> FormLoad { get; set; }
        int ImageNumber { get; set; }   
        Timer Timer { get; set; }
    }
}

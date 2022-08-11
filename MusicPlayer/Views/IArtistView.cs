using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Views
{
    internal interface IArtistView
    {
        Guna.UI2.WinForms.Guna2GradientPanel AnimationPanel { get; set; }
        Guna.UI2.WinForms.Guna2GradientPanel ArtistPicturePanel { get; set; }
        Guna.UI2.WinForms.Guna2GradientPanel RecomendAlbumPanel { get; set; }
        Guna.UI2.WinForms.Guna2GradientPanel MusicPanel { get; set; }
        
    }
}

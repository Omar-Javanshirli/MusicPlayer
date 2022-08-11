using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Views
{
    internal interface IPhotoAndAlbumName
    {
        string Image { get; set; }  
        string SingerName { get; set; }
        string AlbumName { get; set; }
    }
}

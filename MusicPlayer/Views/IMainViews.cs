using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Views
{
    internal interface IMainViews
    {
        EventHandler<EventArgs> PlaylistButton { get; set; }
        EventHandler<EventArgs> ArtistButton { get; set; }
        EventHandler<EventArgs> SongsButton { get; set; }
        EventHandler<EventArgs> AlbumsButton { get;set; }   
        EventHandler<EventArgs> StoreButton { get; set; }   
        EventHandler<EventArgs> ForYouButton { get; set; } 


    }
}

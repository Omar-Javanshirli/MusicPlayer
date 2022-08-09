﻿using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using MusicPlayer.MusicModels;

namespace MusicPlayer.Views
{
    internal interface IMainViews
    {
        EventHandler<EventArgs> PlaylistButton { get; set; }
        EventHandler<EventArgs> ArtistButton { get; set; }
        EventHandler<EventArgs> SongsButton { get; set; }
        EventHandler<EventArgs> AlbumsButton { get; set; }
        EventHandler<EventArgs> StoreButton { get; set; }
        EventHandler<EventArgs> ForYouButton { get; set; }
        SingerAbout singerAbout { get; set; }
        Music music { get; set; }
        System.Windows.Forms.Panel singerAboutPanel { get; set; }
        System.Windows.Forms.Panel MusicPanel { get; set; }
        System.Windows.Forms.Panel SingersPanel { get; set; }
        string SongNameLbl { get; set; }
        string SingerNameLbl { get; set; }
        string SongNameLbl2 { get; set; }
        string SingerNameLbl2 { get; set; }
        string SingerNameLbl3 { get; set; }
        string SongNameLbl3 { get; set; }

    }
}

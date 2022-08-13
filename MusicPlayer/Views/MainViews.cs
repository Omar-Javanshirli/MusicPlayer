﻿
using MusicPlayer.MusicModels;
using MusicPlayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MusicPlayer
{
    public partial class Form1 : Form, IMainViews
    {
        public Form1()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> PlaylistButton { get; set; }
        public EventHandler<EventArgs> ArtistButton { get; set; }
        public EventHandler<EventArgs> SongsButton { get; set; }
        public EventHandler<EventArgs> AlbumsButton { get; set; }
        public EventHandler<EventArgs> StoreButton { get; set; }
        public EventHandler<EventArgs> ForYouButton { get; set; }
        public SingerAbout singerAbout { get; set; }
        public Panel SearchPanel { get => searchPanel; set => searchPanel = value; }
        public Music music { get; set; }
        public Panel MusicPanel { get => musicPanel; set => musicPanel = (Guna.UI2.WinForms.Guna2GradientPanel)value; }
        public Panel SingersPanel { get => singersPanel; set => singersPanel = (Guna.UI2.WinForms.Guna2GradientPanel)value; }
        private void artistsBtn_Click(object sender, EventArgs e)
        {
            ArtistButton.Invoke(sender, e);
        }

        private void albumsBtn_Click(object sender, EventArgs e)
        {
            AlbumsButton.Invoke(sender, e);
        }

        private void songsBtn_Click(object sender, EventArgs e)
        {
            SongsButton.Invoke(sender, e);
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            StoreButton.Invoke(sender, e);
        }

        private void forYouBtn_Click(object sender, EventArgs e)
        {
            ForYouButton.Invoke(sender, e);
        }

        private void playlistBtn_Click_1(object sender, EventArgs e)
        {
            PlaylistButton.Invoke(sender, e);
        }
    }
}

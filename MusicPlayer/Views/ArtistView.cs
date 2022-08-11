using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Views
{
    //Link: https://bashooka.com/inspiration/music-video-player-ui-designs/

    public partial class ArtistView : Form, IArtistView
    {

        public ArtistView()
        {
            InitializeComponent();
        }

        public Guna2GradientPanel AnimationPanel { get => animationPanel; set => animationPanel = value; }
        public Guna2GradientPanel ArtistPicturePanel { get => artistPicturePanel; set => artistPicturePanel = value;  }
        public Guna2GradientPanel RecomendAlbumPanel { get => recomendAlbumsPanel; set => recomendAlbumsPanel = value; }
        public Guna2GradientPanel MusicPanel { get => musicPanel; set => musicPanel = value; }
    }
}

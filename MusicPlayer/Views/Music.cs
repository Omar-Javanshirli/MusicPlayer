using MusicPlayer.Models;
using MusicPlayer.MusicModels;
using MusicPlayer.MusicView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Music : UserControl,IMainMusicView
    {
        public Music()
        {
            InitializeComponent();

        }

        public string Image { get => singersPhoto.ImageLocation; set {
                Helper.GetImage(value, singersPhoto);
            } }
        public string IdLbl { get => numberLbl.Text; set => numberLbl.Text=value; }
        public string SongNameLbl { get => musicName.Text; set => musicName.Text = value; }
        public EventHandler<EventArgs> ForYouButtonClik { get; set; }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            ForYouButtonClik.Invoke(sender,e);
        }
    }
}

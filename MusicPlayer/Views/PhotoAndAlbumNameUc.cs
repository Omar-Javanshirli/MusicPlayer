using Guna.UI2.WinForms;
using MusicPlayer.Models;
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
    public partial class PhotoAndAlbumNameUc : UserControl,IPhotoAndAlbumName
    {
        public PhotoAndAlbumNameUc()
        {
            InitializeComponent();
        }

        public string SingerName { get => singerNameLbl.Text; set => singerNameLbl.Text=value; }
        public string AlbumName { get => albumNameLbl.Text; set => albumNameLbl.Text=value; }
        public string Image { get => singerPhoto.ImageLocation; set => Helper.GetImage(value,singerPhoto); }
        public Guna2PictureBox SingerPhoto { get =>singerPhoto; set => singerPhoto=value; }
        public EventHandler<EventArgs> NextButtonClick { get; set; }
        public EventHandler<EventArgs> PrevButtonClick { get ; set ; }
        public EventHandler<EventArgs> Timer_Tick { get ; set; }
        public EventHandler<EventArgs> FormLoad { get; set; }
        public Timer Timer { get => timer1; set =>timer1=value; }
        public int ImageNumber { get; set; }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClick.Invoke(sender, e);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            PrevButtonClick.Invoke(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer_Tick.Invoke(sender, e);
        }

        private void PhotoAndAlbumNameUc_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);
        }
    }
}

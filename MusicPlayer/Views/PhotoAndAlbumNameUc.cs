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
    }
}

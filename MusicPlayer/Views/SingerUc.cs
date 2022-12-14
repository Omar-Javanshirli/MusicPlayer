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
    public partial class SingerUc : UserControl, ISingerView
    {
        public SingerUc()
        {
            InitializeComponent();
        }

        public string Image { get => singerPhotoPb.ImageLocation; set => Helper.GetImage(value, singerPhotoPb); }
        public string SingerName { get => singerName.Text; set => singerName.Text = value; }
        public string SongName { get => songName.Text; set => songName.Text=value; }
    }
}

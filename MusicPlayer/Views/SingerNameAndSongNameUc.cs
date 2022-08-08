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
    public partial class SingerNameAndSongNameUc : UserControl,ISingerNameAndSongName
    {
        public SingerNameAndSongNameUc()
        {
            InitializeComponent();
        }

        public string SingerName { get => singerNameLbl.Text; set => singerNameLbl.Text=value; }
        public string SongName { get => songNameLbl.Text; set => songNameLbl.Text=value; }
    }
}

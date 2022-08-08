using MusicPlayer.Models;
using MusicPlayer.ViewsSingerPhoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SingerAbout : UserControl,IMainViewSingerAbout
    {
        public SingerAbout()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> SearchButton { get; set; }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchButton?.Invoke(sender,e);
        }
    }
}

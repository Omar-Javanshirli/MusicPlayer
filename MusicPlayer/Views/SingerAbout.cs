using Guna.UI2.WinForms;
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
        public EventHandler<EventArgs> MouseEnterEvent { get ; set ; }
        public Guna2TextBox Searchtext { get => searchTb; set => searchTb=value; }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchButton.Invoke(sender,e);
        }

        private void searchTb_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterEvent.Invoke(sender, e);
        }
    }
}

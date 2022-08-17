using MusicPlayer.MusicDataBase;
using MusicPlayer.ViewsSingerPhoto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.PresentersSingerAbout
{
    public class MainPresenterSingerAbout
    {
        private readonly IMainViewSingerAbout _view;
        private readonly SongContext _db;

        public MainPresenterSingerAbout(IMainViewSingerAbout view)
        {
            _view = view;
            _db = new SongContext();
            _view.MouseEnterEvent += ViewMouseEnter;
            _view.SearchButton += ViewSeachButton;
        }

        public void ViewSeachButton(object sender, EventArgs e)
        {
            foreach (var item in _db.Musics)
            {
                if (_view.Searchtext.Text.ToLower() == item.SongName.ToLower())
                {
                    System.Windows.Forms.MessageBox.Show("Test");
                }
            }
        }

        public void ViewMouseEnter(object sender, EventArgs e)
        {
            if (_view.Searchtext.Text=="Search music")
            {
                _view.Searchtext.Text =string .Empty; 
            }
        }
    }
}

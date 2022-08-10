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

        public MainPresenterSingerAbout(IMainViewSingerAbout view)
        {
            _view = view;
            _view.MouseEnterEvent += ViewMouseEnter;
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

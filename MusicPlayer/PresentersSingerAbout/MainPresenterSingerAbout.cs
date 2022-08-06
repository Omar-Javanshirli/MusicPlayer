using MusicPlayer.ViewsSingerPhoto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.PresentersSingerAbout
{
    internal class MainPresenterSingerAbout
    {
        private readonly IMainViewSingerAbout _view;

        public MainPresenterSingerAbout(IMainViewSingerAbout view)
        {
            _view = view;
        }
    }
}

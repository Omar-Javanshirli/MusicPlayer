using MusicPlayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainViews _view;
        public MainPresenter(IMainViews view)
        {
            _view = view;

            view.PlaylistButton += ViewPlaylistButton;
        }

        public void ViewPlaylistButton(object sender, EventArgs e)
        {
            SingerAbout singerAbout= new SingerAbout();
        }
    }
}

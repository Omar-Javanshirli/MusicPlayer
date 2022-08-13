using MusicPlayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Presenters
{
    internal class PhotoAndAlbumPresenter
    {
        private readonly IPhotoAndAlbumName _view;

        public PhotoAndAlbumPresenter(IPhotoAndAlbumName view)
        {
            _view = view;
            _view.ImageNumber = 1;

            _view.NextButtonClick += ViewNextButtonClick;
            _view.PrevButtonClick += ViewPrevButtonClick;
            _view.Timer_Tick += ViewTimerTick;
            _view.FormLoad += ViewFormLoad;
        }

        private void LoadNextImage()
        {
            _view.Timer.Start();
            _view.ImageNumber++;

            if (_view.ImageNumber > 3)
                _view.ImageNumber = 1;

            _view.SingerPhoto.ImageLocation = string.Format(@"C:\Users\stepguest\Source\Repos\MusicPlayer2\MusicPlayer\Image\" + _view.ImageNumber + ".jpg");
        }

        private void LoadPrevImage()
        {
            _view.Timer.Start();
            _view.ImageNumber--;

            if (_view.ImageNumber < 1)
                _view.ImageNumber = 3;

            _view.SingerPhoto.ImageLocation = string.Format(@"C:\Users\stepguest\Source\Repos\MusicPlayer2\MusicPlayer\Image\" + _view.ImageNumber + ".jpg");
        }
        public void ViewFormLoad(object sender, EventArgs e)
        {
            _view.SingerPhoto.ImageLocation= string.Format(@"C:\Users\stepguest\Source\Repos\MusicPlayer2\MusicPlayer\Image\" + _view.ImageNumber + ".jpg");
        }

        public void ViewTimerTick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        public void ViewPrevButtonClick(object sender, EventArgs e)
        {
            _view.Timer.Stop();
            LoadPrevImage();
        }

        public void ViewNextButtonClick(object sender, EventArgs e)
        {
            _view.Timer.Stop();
            LoadNextImage();
        }
    }
}

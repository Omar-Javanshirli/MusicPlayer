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
            _view.NextButtonClick += ViewNextButtonClick;
        }

        public void ViewNextButtonClick(object sender, EventArgs e)
        {
            PhotoAndAlbumNameUc newSinger = new PhotoAndAlbumNameUc()
            {
                SingerName = "Beyonce in New York",
                AlbumName = "Renaissance",
                Image = "https://live.staticflickr.com/6075/6133385457_8656385682_b.jpg"
            };
        }
    }
}


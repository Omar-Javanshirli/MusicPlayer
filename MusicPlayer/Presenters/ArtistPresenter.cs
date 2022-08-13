using MusicPlayer.MusicDataBase;
using MusicPlayer.MusicModels;
using MusicPlayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Presenters
{
    internal class ArtistPresenter
    {
        private readonly IArtistView _view;
        public ArtistPresenter(IArtistView view)
        {
            _view = view;
            PhotoAndAlbumNameUc rihanna = new PhotoAndAlbumNameUc();
            _view.ArtistPicturePanel.Controls.Add(rihanna);
        }
    }
}

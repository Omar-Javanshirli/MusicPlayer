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
            PhotoAndAlbumNameUc rihanna = new PhotoAndAlbumNameUc()
            {
                AlbumName = "Columbia",
                SingerName = "Rihanna in Columbian",
                Image = "https://cdn11.bigcommerce.com/s-8e25iavqdi/images/stencil/1280x1280/products/8167/7955/only-girl-in-the-world-album-cover-sticker__36794.1539263636.jpg?c=2"
            };
            _view.ArtistPicturePanel.Controls.Add(rihanna);
        }
    }
}

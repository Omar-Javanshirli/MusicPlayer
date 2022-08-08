using MusicPlayer.MusicDataBase;
using MusicPlayer.MusicModels;
using MusicPlayer.MusicView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MusicPresenter
{
    internal class MusicPresenter
    {
        private readonly IMainMusicView _view;
        private readonly SongContext _db;

        public MusicPresenter(IMainMusicView view)
        {
            _view = view;
            _db = new SongContext();


            _view.ForYouButtonClik += ViewForYouButtonClick;
        }

        public void ViewForYouButtonClick(object sender,EventArgs e)
        {
            MusicAbout musicAbout = new MusicAbout()
            {
                Image = _view.image,
                MusicReyting = int.Parse(_view.IdLbl),
                SongName = _view.SongNameLbl
            };
            
            _db.Musics.Add(musicAbout);
            _db.SaveChanges();
        }
    }
}

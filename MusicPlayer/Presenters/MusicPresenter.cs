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
    public class MusicPresenter
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

        }
    }
}

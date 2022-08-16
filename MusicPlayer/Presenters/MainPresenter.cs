using MusicPlayer.MusicDataBase;
using MusicPlayer.MusicModels;
using MusicPlayer.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainViews _view;
        private readonly SongContext _db;
        public MainPresenter(IMainViews view)
        {
            _view = view;

            _view.PlaylistButton += ViewPlaylistButton;
            _view.ArtistButton += ViewArtistButton;
            _db = new SongContext();
            var count = _db.Musics.Count();
            if (count == 0)
            {
                Load();
            }
            LoadFirstPage();
        }

        void LoadFirstPage()
        {
            SingerAbout singerAbout = new SingerAbout();
            _view.singerAbout = singerAbout;
            singerAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            _view.SearchPanel.Controls.Add(singerAbout);

            var musics = _db.Musics;
            int y = 10;
            int x = 130;
            int xx = 70;
            foreach (var m in musics)
            {
                var music = new Music();
                music.Location = new Point(0, y);
                y += 70;
                music.Image = m.Image;
                music.IdLbl = m.Id.ToString();
                music.SongNameLbl = m.SongName.ToString();
                _view.MusicPanel.Controls.Add(music);
            }
            foreach (var item in musics)
            {
                var singer = new SingerUc();
                singer.Location= new Point(x,23);
                singer.Image = item.Image;
                singer.SingerName = item.SingerName;
                singer.SongName = item.SongName;
                x += 250;
                _view.SingersPanel.Controls.Add(singer);
            }
        }
        public void Load()
        {
            MusicAbout musicAbout = new MusicAbout()
            {
                Image = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgG721Q8E9Y26ROWHRmPDULCIRvNe8968EsA&usqp=CAU",
                MusicReyting = 12,
                SongName = "Love Song",
                SingerName="Zak Abel"
            };
            _db.Musics.Add(musicAbout);

            musicAbout = new MusicAbout()
            {
                Image = @"https://media.npr.org/assets/img/2022/05/19/gettyimages-1134174738-76db822abafc0459deb7f2ee9aa517da4bc33254-s1100-c50.jpg",
                MusicReyting = 9,
                SongName = "Kombucha Burps",
                SingerName="Kendrik lamar"
            };
            _db.Musics.Add(musicAbout);

            musicAbout = new MusicAbout()
            {
                Image = @"https://static.dw.com/image/60290826_101.jpg",
                MusicReyting = 12,
                SongName = "Mask Off Soul Flip",
                SingerName = "Esta"
            };
            _db.Musics.Add(musicAbout);
            _db.SaveChanges();
        }
        public void ViewPlaylistButton(object sender, EventArgs e)
        {
            _view.SearchPanel.Controls.Clear();
            _view.MusicPanel.Controls.Clear();
            _view.SingersPanel.Controls.Clear();
            LoadFirstPage();
        }
        public void ViewArtistButton(object sender,EventArgs e)
        {
            ArtistView artistView = new ArtistView();
            artistView.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            var artistPresnter = new ArtistPresenter(artistView);
            artistView.ShowDialog();
        }
    }
}
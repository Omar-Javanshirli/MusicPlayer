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

            view.PlaylistButton += ViewPlaylistButton;
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
            _view.singerAboutPanel.Controls.Add(singerAbout);
            var musics = _db.Musics;
            int y = 10;
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
        }

        public void Load()
        {
            MusicAbout musicAbout = new MusicAbout()
            {
                Image = @"https://cdn-icons-png.flaticon.com/512/3844/3844724.png",
                MusicReyting = 12,
                SongName = "Edd Sheron"
            };

            _db.Musics.Add(musicAbout);

            musicAbout = new MusicAbout()
            {
                Image = @"https://cdn-icons-png.flaticon.com/512/3844/3844724.png",
                MusicReyting = 9,
                SongName = "Namiq Qarachuxurlu"
            };
            _db.Musics.Add(musicAbout);

            musicAbout = new MusicAbout()
            {
                Image = @"https://cdn-icons-png.flaticon.com/512/3844/3844724.png",
                MusicReyting = 12,
                SongName = "Rihanna Diamond"
            };

            _db.Musics.Add(musicAbout);

            _db.SaveChanges();
        }

        public void ViewPlaylistButton(object sender, EventArgs e)
        {

            _view.singerAboutPanel.Controls.Clear();
            _view.MusicPanel.Controls.Clear();
            LoadFirstPage();


            //SingerAbout singerAbout = new SingerAbout();
            //_view.singerAbout = singerAbout;
            //singerAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            //_view.singerAboutPanel.Controls.Add(singerAbout);
            //var musics = _db.Musics;
            //int y = 10;
            //foreach (var m in musics)
            //{
            //    var music = new Music();
            //    music.Location = new Point(0, y);
            //    y += 70;
            //    music.Image = m.Image;
            //    music.IdLbl = m.Id.ToString();
            //    music.SongNameLbl = m.SongName.ToString();
            //    _view.Musics.Controls.Add(music);
            //}
        }
    }
}


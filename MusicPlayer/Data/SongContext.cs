using MusicPlayer.MusicModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MusicDataBase
{
    internal class SongContext:DbContext
    {
        public SongContext():base("MusicsDbb")
        {

        }
        public DbSet<MusicAbout> Musics { get; set; }
    }
}

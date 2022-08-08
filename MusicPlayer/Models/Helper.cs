using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Models
{
    internal class Helper
    {
        public static void GetImage(string value, Guna.UI2.WinForms.Guna2PictureBox image)
        {
            var request = WebRequest.Create(value);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                image.Image = Bitmap.FromStream(stream);
            }
        }
    }
}

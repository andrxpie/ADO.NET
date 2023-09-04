using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Spotify_Premium_Lite
{
    class ViewModel
    {
         public SpotifyLiteDbContext database = new();
         public ICollection<Album> lastest => database.Albums.ToList();

        public string DisplayedImage 
        {
            get { return @"C:\Users\dev.STEP\Desktop\R.jpg"; }
        }

        public ViewModel()
        {

        }
    }
}

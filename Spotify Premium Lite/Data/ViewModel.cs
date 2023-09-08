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
        public ICollection<Album> avaiableAlbums => database.Albums.ToList();
        public User currUser => database.Users.Where(x => x.Id == 2).First();

        public ViewModel()
        {

        }
    }
}

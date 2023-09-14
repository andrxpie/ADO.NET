using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Spotify_Premium_Lite
{
    public class ViewModel
    {
        public SpotifyLiteDbContext database { get; set; }
        public ICollection<Album> avaiableAlbums => database.Albums.ToList();
        public User currUser { get; set; }

        public ViewModel(SpotifyLiteDbContext db, User currUser)
        {
            database = db;
            this.currUser = currUser;
        }
    }
}
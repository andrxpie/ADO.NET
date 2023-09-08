using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite.Data
{
    class ListWindowViewModel
    {
        public Album currAlbum { get; set; }
        public string Popularity => "Popularity: " + currAlbum.Listens.ToString() + " listens on Spotify";
        public Artist currArtist => currAlbum.Artist;
        public ICollection<Track> tracks => currAlbum.Tracks;
        public ListWindowViewModel(Album currAlbum)
        {
            this.currAlbum = currAlbum;
        }
    }
}
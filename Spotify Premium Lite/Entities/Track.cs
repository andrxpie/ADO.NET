using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public int Listens { get; set; }
        public TimeSpan Duration { get; set; }
        public string? Picture { get; set; } = "images\\spotifyLite.png";
        public ICollection<Playlist> Playlists { get; set; }
        public string? Lyrics { get; set; }
    }
}
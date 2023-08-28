using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int Listens { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public string Picture { get; set; }
    }
}
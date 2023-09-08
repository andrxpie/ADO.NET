using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Nickname { get; set; }
        public string? Email { get; set; }
        public string? Avatar { get; set; } = "images\\avatar.jpg";
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Track> Favourite { get; set; }
    }
}
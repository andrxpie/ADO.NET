using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsPublic { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string? Nickname { get; set; }
        public string? Description { get; set; }
        public int Subscriptions { get; set; }
        public int Listens { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
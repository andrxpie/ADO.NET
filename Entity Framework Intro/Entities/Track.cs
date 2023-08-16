using Entity_Framework_Intro.Entities;

namespace Entity_Framework_Intro
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumnId { get; set; }
        public Album Albumn { get; set; }
        public TimeSpan Duration { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
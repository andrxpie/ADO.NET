using Entity_Framework_Intro.Entities;

namespace Entity_Framework_Intro
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public int Rating { get; set; }
        public int Listens { get; set; }
        public string? Lyrics { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Duration.ToString()}";
        }
    }
}
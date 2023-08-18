using Entity_Framework_Intro.Entities;

namespace Entity_Framework_Intro
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Track> Music { get; set; }
        public int Rating { get; set; }
    }
}
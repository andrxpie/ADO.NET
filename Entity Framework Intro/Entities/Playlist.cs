namespace Entity_Framework_Intro.Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Track> Track { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
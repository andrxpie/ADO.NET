namespace Entity_Framework_Intro.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Loadings
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
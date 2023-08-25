using System.ComponentModel.DataAnnotations;

namespace EF___Airlines__hw_
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Airplanes> Airplanes { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace EF___Airlines__hw_
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airplanes> Airplanes { get; set; }
    }
}
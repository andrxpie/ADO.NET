using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class Flights
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [ForeignKey ("Airplane")]
        public int AirplaneId { get; set; }
        public Airplanes Airplane { get; set; }
        public ICollection<Clients> Clients { get; set; }

        [Required]
        public DateTime ArivalDate { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [ForeignKey ("ArivalCity")]
        public int CityArivalId { get; set; }
        public City ArivalCity { get; set; }

        [ForeignKey ("DepartureCity")]
        public int CityDepartureId { get; set; }
        public City DepartureCity { get; set; }
    }
}

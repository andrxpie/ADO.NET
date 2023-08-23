using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class Flights
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int AirplaneId { get; set; }
        public Airplanes Airplane { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public DateTime ArivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CityArivalId { get; set; }
        public City ArivalCity { get; set; }
        public int CityDepartureId { get; set; }
        public City DepartureCity { get; set; }
    }
}

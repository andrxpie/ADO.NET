using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class Airplanes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int TypeId { get; set; }
        public AType Type { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class AType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airplanes> Airlplanes { get; set; }
    }
}

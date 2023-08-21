using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loadings
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        public int? ParkingArea { get; set; }
        ICollection<Product> Products { get; set; }
        ICollection<Worker> Workers { get; set; }
    }
}

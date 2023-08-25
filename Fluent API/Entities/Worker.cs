using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loadings
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}

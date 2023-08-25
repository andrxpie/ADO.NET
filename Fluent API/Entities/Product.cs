using Loadings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loadings
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
    }
}

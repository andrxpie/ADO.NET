using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Annotations
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
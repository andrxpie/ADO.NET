using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Annotations
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
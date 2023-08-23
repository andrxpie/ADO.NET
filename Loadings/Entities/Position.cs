using System.ComponentModel.DataAnnotations;

namespace Loadings
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
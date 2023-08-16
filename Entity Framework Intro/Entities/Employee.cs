using Entity_Framework_Intro.Entities;

namespace Entity_Framework_Intro
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
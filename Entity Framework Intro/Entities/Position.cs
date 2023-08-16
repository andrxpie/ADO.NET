namespace Entity_Framework_Intro.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Customers { get; set; }
    }
}
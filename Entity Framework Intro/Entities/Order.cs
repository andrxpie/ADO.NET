using Entity_Framework_Intro.Entities;

namespace Entity_Framework_Intro
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? WaiterId { get; set; }
        public Employee? Waiter { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
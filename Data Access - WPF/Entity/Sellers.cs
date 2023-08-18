namespace Data_Access
{
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Id} => {Name} {Surname}";
        }
    }
}
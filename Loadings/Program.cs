namespace Loadings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopDB shopDB = new ShopDB();

            Console.WriteLine("ID\t\tName\t\tCountryID");
            foreach (var city in shopDB.Cities.ToList()) // Eagerly loading ??
                Console.WriteLine($"{city.Id}\t\t{city.Name}\t\t{city.CountryId}");

            Console.WriteLine("ID\t\tName");
            foreach (var category in shopDB.Categories) // Lazy loading
                Console.WriteLine($"{category.Id}\t\t{category.Name}");

            using (shopDB) // Explicit loading
            {
                var post = shopDB.Workers.Find("James");
                shopDB.Entry(post).Reference(p => p.Name).Load();
            }
        }
    }
}
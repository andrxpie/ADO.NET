namespace Data_Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data sells = new Data();

            // 1
            //Console.WriteLine(">>> Sellers ---");
            //sells.ShowAllFromTable("Sellers");
            //Console.WriteLine("\n>>> Customers ---");
            //sells.ShowAllFromTable("Customers");
            //Console.WriteLine("\n>>> TSells ---");
            //sells.ShowAllFromTable("TSells");

            // 2
            //sells.AddSell();

            //var s = sells.GetSellsByPeriod(new DateOnly(2023, 07, 5), new DateOnly(2023, 07, 10));
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            // 3
            //sells.ShowLastShopByCustomer("John", "Doe");

            // 4 - doesn't works correctly, open Data.cs to review
            //Console.Write("Type true / false (Sellers / Customers) to choose table to update: ");
            //bool table = Convert.ToBoolean(Console.ReadLine()); Console.WriteLine();

            //Console.Write("Type Id: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //sells.DeleteSellerOrCustomerById(id, table);

            // 5
            //var richestSeller = sells.RichestSeller();
            //foreach (var item in richestSeller)
            //    Console.WriteLine(item);
        }
    }
}
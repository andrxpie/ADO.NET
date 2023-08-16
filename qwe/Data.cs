using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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

    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class TSells
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Id} => {CustomerId}, {SellerId} ({Price}$ - {Date.ToString("yyyy-MM-dd")})";
        }
    }

    internal class Data
    {
        private SqlConnection connection = null;
        private int rows = 20;
        
        public Data(string? connectionStr = null)
        {
            connectionStr ??= ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;

            connection = new SqlConnection(connectionStr);
            connection.Open();
        }

        private void ShowTable(SqlDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                Console.Write($"{reader.GetName(i),-10}\t");
            Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write($"{reader[i],-10}\t");
                Console.WriteLine();
            }

            reader.Close();
        }

        public void AddSell()
        {
            int customerId = 0;
            int sellerId = 0;            

            Console.Clear();
            Console.Write("price: "); decimal price = Convert.ToDecimal(Console.ReadLine());

            while(sellerId <= 0 || sellerId > rows)
            {
                Console.Clear();
                Console.Write($"Seller (Id in 1 and {rows}): ");
                sellerId = Convert.ToInt32(Console.ReadLine());
            }

            while(customerId <= 0 || customerId > rows)
            {
                Console.Clear();
                Console.Write($"Customer (Id in 1 and {rows}): ");
                customerId = Convert.ToInt32(Console.ReadLine());
            } Console.Clear();

            DateOnly date = new DateOnly();
            string cmd = "insert TSells values(@sellerId, @customerId, @price, @date)";

            SqlCommand command = new SqlCommand(cmd, connection);

            command.Parameters.AddWithValue("@sellerId", sellerId);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@date", $"{date.ToString("yyyy-MM-dd")}");

            command.ExecuteNonQuery();
        }

        public IEnumerable<TSells> GetSellsByPeriod(DateOnly p1, DateOnly p2)
        {
            string cmdText = @"select * from TSells
where Date between @p1 and @p2";
            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@p1", p1.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p2", p2.ToString("yyyy-MM-dd"));

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                yield return new TSells()
                {
                    Id = (int)reader["Id"],
                    SellerId = (int)reader["SellerId"],
                    CustomerId = (int)reader["CustomerId"],
                    Date = (DateTime)reader["Date"],
                    Price = (decimal)reader["Price"]
                };
            }
        }

        public void ShowLastShopByCustomer(string name, string surname)
        {
            string cmdText = @$"select TOP 1 c.* from Customers as c JOIN TSells as ts ON ts.CustomerId = c.Id
where c.Name = @name and c.Surname = @surname
order by ts.Date desc";
            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);

            using var reader = command.ExecuteReader();
            ShowTable(reader);
        }

        public void DeleteSellerOrCustomerById(int id, bool table)
        {
            string tableNotBoolean = table ? "Sellers" : "Customers";
            string colRef = table ? "SellerId" : "CustomerId";

            string cmdText = @"delete from TSells where @ref = @id
delete from @table where Id = @id";
            SqlCommand command = new SqlCommand(cmdText, connection);

            command.Parameters.AddWithValue("@ref", colRef);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@table", tableNotBoolean); // error

            command.ExecuteNonQuery(); // crash on it, 'cause line 154 can't declare var @table by tableNotBoolean, idk why
        }

        public IEnumerable<Sellers> RichestSeller()
        {
            string cmdText = @"select TOP 1 s.*
from Sellers as s JOIN TSells as ts ON ts.SellerId = s.Id
group by s.Id, s.Name, s.Surname
order by COUNT(ts.Price) desc";
            SqlCommand command = new SqlCommand(cmdText, connection);

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                yield return new Sellers()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Surname = (string)reader["Surname"],
                };
            }
        }

        public void ShowAllFromTable(string table)
        {
            string cmdText = $"select * from {table}";
            SqlCommand command = new SqlCommand(cmdText, connection);

            using var reader = command.ExecuteReader();
            ShowTable(reader);
        }
    }
}
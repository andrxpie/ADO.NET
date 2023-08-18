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
    public class Data
    {
        private SqlConnection connection = null;
        private int rows = 20;
        
        public Data(string? connectionStr = null)
        {
            connectionStr ??= ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;

            connection = new SqlConnection(connectionStr);
            connection.Open();
        }

        public IEnumerable<Sellers> GetSellers()
        {
            string cmdText = "select * from Sellers";
            SqlCommand command = new SqlCommand(cmdText, connection);

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                yield return new Sellers()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Surname = (string)reader["Surname"]
                };
            }
        }

        public IEnumerable<Customers> GetCustomers()
        {
            string cmdText = "select * from Customers";
            SqlCommand command = new SqlCommand(cmdText, connection);

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                yield return new Customers()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Surname = (string)reader["Surname"]
                };
            }
        }

        public IEnumerable<TSells> GetSells()
        {
            string cmdText = "select * from TSells";
            SqlCommand command = new SqlCommand(cmdText, connection);

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                yield return new TSells()
                {
                    Id = (int)reader["Id"],
                    CustomerId = (int)reader["CustomerId"],
                    SellerId = (int)reader["SellerId"],
                    Price = (decimal)reader["Price"],
                    Date = (DateTime)reader["Date"]
                };
            }
        }
    }
}
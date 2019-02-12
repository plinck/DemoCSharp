using System;
using System.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace ClassDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person paul = new Person("Paul");

                Console.WriteLine($"Hello {paul.Name}");

                var connStr =
                    System.Configuration.ConfigurationManager.
                        ConnectionStrings["bamazon"].ConnectionString;
                var conn = new MySqlConnection(connStr);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                var cmd = new MySqlCommand(@"SELECT * FROM products;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                    
                DataTable products = new DataTable();
                products.Load(reader);

                foreach (DataRow row in products.Rows)
                {
                    Console.WriteLine(row["product_name"].ToString());
                }

                Console.ReadLine();
            }

        }
    }
}

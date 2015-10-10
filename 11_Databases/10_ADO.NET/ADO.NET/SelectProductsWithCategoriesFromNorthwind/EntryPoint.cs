namespace SelectProductsWithCategoriesFromNorthwind
{
    using System;
    using System.Data.SqlClient;

    public class EntryPoint
    {
        public static void Main()
        {
            SqlConnection connection =
                new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");

            connection.Open();

            using (connection)
            {
                SqlCommand selectProductsWithCategoriesCommand =
                    new SqlCommand("SELECT c.CategoryName , p.ProductName FROM Categories c JOIN Products p ON c.CategoryId = p.CategoryID GROUP BY c.CategoryName, p.ProductName", connection);

                var reader = selectProductsWithCategoriesCommand.ExecuteReader();

                Console.WriteLine("Categories with products:");
                while (reader.Read())
                {
                    var categoryName = reader["CategoryName"];
                    var productName = reader["ProductName"];

                    Console.WriteLine("{0} -> {1}", categoryName, productName);
                }
            }
        }
    }
}

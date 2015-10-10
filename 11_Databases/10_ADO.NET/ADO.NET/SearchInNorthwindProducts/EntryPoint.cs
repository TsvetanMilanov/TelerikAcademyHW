namespace SearchInNorthwindProducts
{
    using System;
    using System.Data.SqlClient;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Enter products filter:");
            string productsFilter = Console.ReadLine();
            productsFilter = EscapeSpecialCharacters(productsFilter);

            SqlConnection connection =
                new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");

            connection.Open();

            using (connection)
            {
                string query = "SELECT ProductName FROM Products WHERE ProductName LIKE '%" + productsFilter + "%'";
                SqlCommand selectFilteredProducts = new SqlCommand(query, connection);
                Console.WriteLine(query);

                var reader = selectFilteredProducts.ExecuteReader();

                Console.WriteLine("Filtered products:");

                while (reader.Read())
                {
                    string currentProductName = (string)reader["ProductName"];

                    Console.WriteLine(currentProductName);
                }
            }
        }

        private static string EscapeSpecialCharacters(string input)
        {
            input.Replace("\\", "\\\\");
            input.Replace("\"", "\\\"");
            input.Replace("%", "\\%");
            input.Replace("'", "\\'");
            input.Replace("_", "\\_");

            return input;
        }
    }
}

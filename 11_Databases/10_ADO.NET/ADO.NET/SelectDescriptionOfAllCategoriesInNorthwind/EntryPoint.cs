namespace SelectDescriptionOfAllCategoriesInNorthwind
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
                SqlCommand selectDescriptionCommand = new SqlCommand("SELECT Description FROM Categories", connection);

                SqlDataReader reader = selectDescriptionCommand.ExecuteReader();

                Console.WriteLine("The descriptions of the categories are:");
                while (reader.Read())
                {
                    string categoryDescription = (string)reader["Description"];

                    Console.WriteLine(categoryDescription);
                }
            }
        }
    }
}

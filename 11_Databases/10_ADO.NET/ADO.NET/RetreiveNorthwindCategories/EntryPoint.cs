namespace RetreiveNorthwindCategories
{
    using System;
    using System.Data.SqlClient;

    public class EntryPoint
    {
        public static void Main()
        {
            SqlConnection connection =
                new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind; Integrated Security = true");

            connection.Open();

            using (connection)
            {
                SqlCommand selectCategoriesCommand = new SqlCommand("SELECT COUNT(*) FROM Categories", connection);
                int categoriesCount = (int)selectCategoriesCommand.ExecuteScalar();

                Console.WriteLine("The number of categories is: {0}", categoriesCount);
            }
        }
    }
}

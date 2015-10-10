namespace AddNewProductToNorthwind
{
    using System;
    using System.Data.SqlClient;

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            SqlConnection connection =
                new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");

            connection.Open();

            using (connection)
            {
                SqlCommand insertProductcommand =
                    new SqlCommand("INSERT INTO Products" +
                    "(ProductName, SupplierID, CategoryID, QuantityPerUnit," +
                    " UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)" +
                    " VALUES(@productName, @supplierId, @categoryId, @quantityPerUnit," +
                    " @unitPrice, @unitsInStock, @unitsInOrder, @reorderLevel, @discontinued)", connection);

                insertProductcommand.Parameters.AddWithValue("@productName", "Some product");
                insertProductcommand.Parameters.AddWithValue("@supplierId", 1);
                insertProductcommand.Parameters.AddWithValue("@categoryId", 1);
                insertProductcommand.Parameters.AddWithValue("@quantityPerUnit", "some quantity");
                insertProductcommand.Parameters.AddWithValue("@unitPrice", 2M);
                insertProductcommand.Parameters.AddWithValue("@unitsInStock", 100);
                insertProductcommand.Parameters.AddWithValue("@unitsInOrder", 5);
                insertProductcommand.Parameters.AddWithValue("@reorderLevel", 7);
                insertProductcommand.Parameters.AddWithValue("@discontinued", 1);

                insertProductcommand.ExecuteNonQuery();
            }
        }
    }
}

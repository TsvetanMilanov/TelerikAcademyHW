namespace StoreImagesFromNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;

    public class EntryPoint
    {
        public static void Main()
        {
            SqlConnection connection =
                new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");

            connection.Open();

            using (connection)
            {
                SqlCommand selectImagesCommand = new SqlCommand("SELECT Picture FROM Categories", connection);

                var reader = selectImagesCommand.ExecuteReader();

                int currentImageIndex = 0;
                string imageName = "image#";
                string imageExtension = ".jpg";

                while (reader.Read())
                {
                    var imageArray = (byte[])reader["Picture"];

                    string imageFullName = imageName + currentImageIndex + imageExtension;

                    FileStream imageStream = File.OpenWrite(imageFullName);

                    imageStream.Write(imageArray, 0, imageArray.Length);

                    imageStream.Dispose();

                    currentImageIndex += 1;
                }
            }
        }
    }
}

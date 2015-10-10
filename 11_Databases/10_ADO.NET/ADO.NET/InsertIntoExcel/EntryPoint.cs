namespace InsertIntoExcel
{
    using System;
    using System.Data.OleDb;
    using System.IO;

    public class EntryPoint
    {
        public static void Main()
        {
            string currentFolderPath = Directory.GetCurrentDirectory();

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + currentFolderPath + "\\Scores.xlsx" + ";Extended Properties=\"Excel 12.0 Xml; HDR = YES\"");

            connection.Open();

            using (connection)
            {
                OleDbCommand insertQuery = new OleDbCommand("INSERT INTO [ScoresDB$] VALUES(\"Pesho\", 25)", connection);

                insertQuery.ExecuteNonQuery();
            }
        }
    }
}

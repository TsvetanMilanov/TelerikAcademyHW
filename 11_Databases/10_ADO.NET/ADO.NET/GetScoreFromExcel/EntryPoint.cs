namespace GetScoreFromExcel
{
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            string currentFolderPath = Directory.GetCurrentDirectory();

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + currentFolderPath + "\\Scores.xlsx" + ";Extended Properties=\"Excel 12.0 Xml; HDR = YES\"");

            connection.Open();

            using (connection)
            {
                var query = new OleDbCommand("SELECT Name, Score FROM [ScoresDB$]", connection);
                var reader = query.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];

                    Console.WriteLine("{0} -> {1}", name, score);
                }
            }
        }
    }
}

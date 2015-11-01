namespace Logs.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Logs.Data;
    using Logs.Data.Migrations;
    using Logs.DataImporter;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LogsDbContext>());
            using (var db = new LogsDbContext())
            {
                DataImporter dataImporter = new DataImporter();

                dataImporter.ImportLogs(db);
            }
        }
    }
}

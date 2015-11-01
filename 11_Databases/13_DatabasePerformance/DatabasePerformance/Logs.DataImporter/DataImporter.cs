namespace Logs.DataImporter
{
    using System;

    using Logs.Data;
    using Logs.Models;

    public class DataImporter
    {
        private const int NumberOfLogs = 3000000;

        public void ImportLogs(LogsDbContext db)
        {
            db.Configuration.AutoDetectChangesEnabled = false;
            db.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.ValidateOnSaveEnabled = false;

            Console.WriteLine("Adding Logs to Database!");

            for (int i = 0; i < NumberOfLogs; i++)
            {
                var logToAdd = new Log
                {
                    Text = RandomDataGenerator.GetRandomString(maxLength: 100),
                    Date = RandomDataGenerator.GetRandomDate()
                };

                db.Logs.Add(logToAdd);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                    db.Dispose();
                    db = new LogsDbContext();
                }

                if (i % 10000 == 0)
                {
                    Console.Write(".");
                }
            }

            db.Configuration.AutoDetectChangesEnabled = true;
            db.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
            db.Configuration.LazyLoadingEnabled = true;
            db.Configuration.ProxyCreationEnabled = true;
            db.Configuration.ValidateOnSaveEnabled = true;
            Console.WriteLine();
        }
    }
}

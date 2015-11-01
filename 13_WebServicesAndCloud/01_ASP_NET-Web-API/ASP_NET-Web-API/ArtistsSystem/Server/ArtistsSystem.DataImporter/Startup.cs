namespace ArtistsSystem.DataImporter
{
    using System;
    using System.Data.Entity;

    using Data;
    using Data.Migrations;
    using Importers;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ArtistsSystemDbContext>());

            var db = new ArtistsSystemDbContext();

            DataImporter artistsSystemDataImporter = new ArtistsSystemDataImporter();

            artistsSystemDataImporter.AddDataImporter(new CountriesImporter());
            artistsSystemDataImporter.AddDataImporter(new ProducersImporter());
            artistsSystemDataImporter.AddDataImporter(new AlbumsImporter());
            artistsSystemDataImporter.AddDataImporter(new ArtistsImporter());
            artistsSystemDataImporter.AddDataImporter(new SongsImporter());

            Console.WriteLine("Seedeing initial data to database!");
            artistsSystemDataImporter.ImportData(db);
            Console.WriteLine("Done!");
        }
    }
}

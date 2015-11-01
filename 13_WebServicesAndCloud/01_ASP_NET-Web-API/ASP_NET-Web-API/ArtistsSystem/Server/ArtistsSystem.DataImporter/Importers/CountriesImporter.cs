namespace ArtistsSystem.DataImporter.Importers
{
    using Data;
    using Models;

    public class CountriesImporter : DataImporter
    {
        public override void ImportData(IArtistsSystemDbContext database)
        {
            database.Countries.Add(new Country
            {
                Name = "Bulgaria"
            });

            database.Countries.Add(new Country
            {
                Name = "Germany"
            });

            database.SaveChanges();
        }
    }
}

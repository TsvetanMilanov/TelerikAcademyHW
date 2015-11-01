namespace ArtistsSystem.DataImporter.Importers
{
    using Data;
    using Models;

    public class ProducersImporter : DataImporter
    {
        public override void ImportData(IArtistsSystemDbContext database)
        {
            database.Producers.Add(new Producer
            {
                Name = "Trap producer"
            });

            database.Producers.Add(new Producer
            {
                Name = "Hardcore producer"
            });

            database.Producers.Add(new Producer
            {
                Name = "Dubstep producer"
            });

            database.SaveChanges();
        }
    }
}

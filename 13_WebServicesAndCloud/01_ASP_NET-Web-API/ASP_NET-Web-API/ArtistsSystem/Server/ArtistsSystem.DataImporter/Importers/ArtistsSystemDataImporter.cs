namespace ArtistsSystem.DataImporter.Importers
{
    using Data;

    public class ArtistsSystemDataImporter : DataImporter
    {
        public override void ImportData(IArtistsSystemDbContext database)
        {
            foreach (var importer in this.DataImporters)
            {
                importer.ImportData(database);
            }
        }
    }
}

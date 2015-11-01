namespace ArtistsSystem.DataImporter.Importers
{
    using System.Collections.Generic;

    using Data;

    public abstract class DataImporter
    {
        public DataImporter()
        {
            this.DataImporters = new List<DataImporter>();
        }

        public ICollection<DataImporter> DataImporters { get; set; }

        public void AddDataImporter(DataImporter importer)
        {
            this.DataImporters.Add(importer);
        }

        public void RemoveDataImporter(DataImporter importer)
        {
            this.DataImporters.Remove(importer);
        }

        public abstract void ImportData(IArtistsSystemDbContext database);
    }
}

namespace StudentsSystem.DataImporter
{
    using Data;

    public abstract class DataImporter
    {
        public DataImporter(DataCreator builder)
        {
            this.Builder = builder;
        }

        public DataCreator Builder { get; private set; }

        public abstract void ImportData();
    }
}

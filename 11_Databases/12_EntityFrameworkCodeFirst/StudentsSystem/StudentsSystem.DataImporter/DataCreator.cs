namespace StudentsSystem.DataImporter
{
    using Data;

    public abstract class DataCreator
    {
        public DataCreator(StudentsSystemDbContext db)
        {
            this.Database = db;
        }

        public StudentsSystemDbContext Database { get; set; }

        public abstract void AddStudentsToDatabase();

        public abstract void AddCoursesToDatabase();

        public abstract void AddHomeworkToDatabase();

        public abstract void AddMaterialsToDatabase();
    }
}
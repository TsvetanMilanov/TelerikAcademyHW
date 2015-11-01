namespace StudentsSystem.DataImporter
{
    public class StudentsSystemDataImporter : DataImporter
    {
        public StudentsSystemDataImporter(DataCreator builder)
            : base(builder)
        {
        }

        public override void ImportData()
        {
            this.Builder.AddCoursesToDatabase();
            this.Builder.AddStudentsToDatabase();
            this.Builder.AddMaterialsToDatabase();
            this.Builder.AddHomeworkToDatabase();
        }
    }
}

namespace StudentsSystem.Data
{
    using System.Data.Entity;

    using Models;

    public class StudentsSystemDbContext : DbContext
    {
        public StudentsSystemDbContext()
            : base("StudentsSystem")
        {
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homework { get; set; }

        public IDbSet<Material> Materials { get; set; }
    }
}

namespace StudentsSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Data;
    using Data.Migrations;
    using DataImporter;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsSystemDbContext, Configuration>());

            using (var db = new StudentsSystemDbContext())
            {
                DataCreator builder = new StudentsSystemDataCreator(db);

                DataImporter dataImporter = new StudentsSystemDataImporter(builder);

                dataImporter.ImportData();
            }

            using (var db = new StudentsSystemDbContext())
            {
                var studentsWithCoursesAndHomework = db.Students
                    .Select(s => new
                    {
                        StudentName = s.Name,
                        CoursesCount = s.Courses.Count,
                        HomeworkCount = s.Homeworks.Count
                    })
                    .ToList();

                Console.WriteLine("Students with courses and homework:");

                foreach (var student in studentsWithCoursesAndHomework)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine(
                        "Student: {0}\nCourses count: {1}\nHomework count: {2}",
                        student.StudentName,
                        student.CoursesCount,
                        student.HomeworkCount);
                    Console.WriteLine("========================================");
                }
            }
        }
    }
}

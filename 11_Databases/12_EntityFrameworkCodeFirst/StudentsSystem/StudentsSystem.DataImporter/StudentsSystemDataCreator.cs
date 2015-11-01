namespace StudentsSystem.DataImporter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Data;
    using Models;

    public class StudentsSystemDataCreator : DataCreator
    {
        private const int NumberOfCoursesToAdd = 20;
        private const int NumberOfStudentsToAdd = 1000;
        private const int NumberOfHomeworkToAdd = 5000;
        private const int NumberOfMaterialsToAdd = 2000;

        public StudentsSystemDataCreator(StudentsSystemDbContext db)
            : base(db)
        {
        }

        public override void AddCoursesToDatabase()
        {
            Console.WriteLine("Adding Courses to Database!");

            for (int i = 0; i < NumberOfCoursesToAdd; i++)
            {
                var courseToAdd = new Course
                {
                    Name = RandomDataGenerator.GetRandomString(3, 50),
                    Description = RandomDataGenerator.GetRandomString(3, 200)
                };

                this.Database.Courses.Add(courseToAdd);
                Console.Write(".");

                if (i % 100 == 0)
                {
                    this.Database.SaveChanges();
                    this.Database.Dispose();
                    this.Database = new StudentsSystemDbContext();
                }
            }

            this.Database.SaveChanges();
            Console.WriteLine();
        }

        public override void AddHomeworkToDatabase()
        {
            Console.WriteLine("Adding Homework to Database!");

            var studentsIds = this.Database.Students
                .OrderBy(s => Guid.NewGuid())
                .Select(s => s.Id)
                .ToList();

            var coursesIds = this.Database.Courses
                .OrderBy(c => Guid.NewGuid())
                .Select(c => c.Id)
                .ToList();

            var averageHomeworkPerCourse = NumberOfHomeworkToAdd / coursesIds.Count;
            var currentCourseIndex = 0;
            var currentCourseId = coursesIds[currentCourseIndex];

            for (int i = 0; i < NumberOfHomeworkToAdd; i++)
            {
                if (i > 0 && i % averageHomeworkPerCourse == 0 && currentCourseIndex < coursesIds.Count - 1)
                {
                    currentCourseIndex += 1;

                    currentCourseId = coursesIds[currentCourseIndex];
                }

                var studentId = studentsIds[i % studentsIds.Count];
                var homeworkToAdd = new Homework
                {
                    Content = RandomDataGenerator.GetRandomString(20, 300),
                    TimeSent = RandomDataGenerator.GetRandomDate(),
                    StudentId = studentId,
                    CourseId = currentCourseId
                };

                this.Database.Homework.Add(homeworkToAdd);

                if (i % 500 == 0)
                {
                    Console.Write(".");
                }

                if (i % 100 == 0)
                {
                    this.Database.SaveChanges();
                    this.Database.Dispose();
                    this.Database = new StudentsSystemDbContext();
                }
            }

            this.Database.SaveChanges();
            Console.WriteLine();
        }

        public override void AddMaterialsToDatabase()
        {
            Console.WriteLine("Adding materials to Database!");

            var allCoursesIds = this.Database.Courses
                .OrderBy(c => Guid.NewGuid())
                .Select(c => c.Id)
                .ToList();

            var currentCourseIndex = 0;
            var currentCourseId = allCoursesIds[currentCourseIndex];
            var averageMaterialsPerCourse = NumberOfMaterialsToAdd / allCoursesIds.Count;

            for (int i = 0; i < NumberOfMaterialsToAdd; i++)
            {
                if (i > 0 && i % averageMaterialsPerCourse == 0 && currentCourseIndex < allCoursesIds.Count)
                {
                    currentCourseId = allCoursesIds[currentCourseIndex];

                    currentCourseIndex += 1;
                }

                var materialToAdd = new Material
                {
                    Content = RandomDataGenerator.GetRandomString(20, 300),
                    CourseId = currentCourseId
                };

                this.Database.Materials.Add(materialToAdd);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Database.SaveChanges();
                    this.Database.Dispose();
                    this.Database = new StudentsSystemDbContext();
                }
            }

            this.Database.SaveChanges();
            Console.WriteLine();
        }

        public override void AddStudentsToDatabase()
        {
            Console.WriteLine("Adding Students to Database!");

            var studentsNumbers = new List<int>();

            var allCourses = this.Database.Courses
                .OrderBy(c => Guid.NewGuid())
                .ToList();

            while (studentsNumbers.Count < NumberOfStudentsToAdd)
            {
                int numberToAdd = RandomDataGenerator.GetRandomNumberInRange(0);

                if (!studentsNumbers.Contains(numberToAdd))
                {
                    studentsNumbers.Add(numberToAdd);
                }
            }

            for (int i = 0; i < NumberOfStudentsToAdd; i++)
            {
                var studentToAdd = new Student
                {
                    Name = RandomDataGenerator.GetRandomString(1, 20),
                    Number = studentsNumbers[i]
                };

                var coursesForStudent = new HashSet<Course>();

                var numberOfCoursesForStudent = RandomDataGenerator.GetRandomNumberInRange(1, 7);

                while (coursesForStudent.Count < numberOfCoursesForStudent)
                {
                    var courseToAdd = allCourses[RandomDataGenerator.GetRandomNumberInRange(0, allCourses.Count - 1)];

                    coursesForStudent.Add(courseToAdd);
                }

                studentToAdd.Courses = coursesForStudent;
                this.Database.Students.Add(studentToAdd);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Database.SaveChanges();
                    this.Database.Dispose();
                    this.Database = new StudentsSystemDbContext();
                    allCourses = this.Database.Courses
                        .OrderBy(c => Guid.NewGuid())
                        .ToList();
                }
            }

            this.Database.SaveChanges();
            Console.WriteLine();
        }
    }
}

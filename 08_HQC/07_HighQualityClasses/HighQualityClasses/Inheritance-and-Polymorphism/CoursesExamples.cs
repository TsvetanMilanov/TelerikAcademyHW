namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", "Svetlin Nakov", "Ultimate");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.AddStudents(new List<string>() { "Peter", "Maria" });
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev",
                "Sofia",
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}

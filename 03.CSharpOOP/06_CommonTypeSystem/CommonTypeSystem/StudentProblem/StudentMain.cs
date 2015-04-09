namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Students.Enumerations;

    /*
     Problems 1, 2 and 3.
     */

    public class StudentMain
    {
        public static void Main(string[] args)
        {
            Student firstStudent = new Student(
                                                "Pesho",
                                                "Peshov",
                                                "Peshov",
                                                12134314,
                                                "some address",
                                                "+359888 888 888",
                                                "someEmail@abv.bg",
                                                UniversityEnum.TechnicalUniversity,
                                                FacultyEnum.FTK,
                                                SpecialtyEnum.TK,
                                                CourseEnum.First);

            Student testEqualStudent = new Student(
                                                "Pesho",
                                                "Peshov",
                                                "Peshov",
                                                12134314,
                                                "some address",
                                                "+359888 888 888",
                                                "someEmail@abv.bg",
                                                UniversityEnum.TechnicalUniversity,
                                                FacultyEnum.FTK,
                                                SpecialtyEnum.TK,
                                                CourseEnum.First);

            Student secondStudent = new Student(
                                                "Gosho",
                                                "Goshov",
                                                "Goshov",
                                                12134315,
                                                "another address",
                                                "+359888 999 999",
                                                "anotherEmail@gmail.com",
                                                UniversityEnum.TelericAcademy,
                                                FacultyEnum.Ninja,
                                                SpecialtyEnum.TelericAcademyNinja,
                                                CourseEnum.Second);

            Console.WriteLine("First student equals second student: {0}", firstStudent.Equals(secondStudent));

            Console.WriteLine("First student == test equal student student: {0}", firstStudent == testEqualStudent);

            Console.WriteLine("\nStudent.ToString():\n{0}", firstStudent.ToString());

            Student clonedStudent = (Student)secondStudent.Clone();

            Console.WriteLine("Deep cloned student:\n{0}", clonedStudent.ToString());

            Console.WriteLine("First student compared to second student: {0}", firstStudent.CompareTo(secondStudent));

            Console.WriteLine("Second student compared to cloned student: {0}", secondStudent.CompareTo(clonedStudent));

            Console.WriteLine("Second student compared to first student: {0}", secondStudent.CompareTo(firstStudent));
        }
    }
}

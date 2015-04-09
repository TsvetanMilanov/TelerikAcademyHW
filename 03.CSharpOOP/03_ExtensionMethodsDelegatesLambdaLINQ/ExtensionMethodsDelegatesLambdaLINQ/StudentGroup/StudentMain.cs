namespace StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
        Problems 9, 10, 11, 12, 13, 14, 15, 16
     */

    public class StudentMain
    {
        public static void Main(string[] args)
        {
            /// Make list of students.
            List<Student> listOfStudents = InitializeList();

            /// Sort students from group two with LINQ.
            SortStudentsInGroupTwoWithLinq(listOfStudents);

            /// Sort students from froup two with extension methods.
            SortStudentsFromGroupTwoWithExtensionMethods(listOfStudents);

            /// Extract students with emails in abv.bg.
            ExtractStudentsByEmail(listOfStudents);

            /// Extract students with phone in Sofia.
            ExtractStudentsByPhone(listOfStudents);

            /// Extract students with atleast one mark Excellent.
            ExtractStudentsByMarks(listOfStudents);

            /// Extract students with exactly two marks 2.
            ExtractStudentsWithTwoMarks(listOfStudents);

            /// Extract marks of students in 2006.
            ExtractStudentsByMarksInYear(listOfStudents);

            /// Extract all students from Mathematics department.
            ExtractStudentsFromDepartment(listOfStudents);
        }

        public static void ExtractStudentsFromDepartment(List<Student> listOfStudents)
        {
            string departmentName = "Mathematics";

            var result = string.Join("\n", listOfStudents.Where(x => x.Group.DepartmentName == departmentName));

            Console.WriteLine("All students in {0} department are:\n\n{1}", departmentName, result);
            Console.WriteLine("==============================================\n");
        }

        public static void ExtractStudentsByMarksInYear(List<Student> listOfStudents)
        {
            var result = listOfStudents
                                        .Where(x => x.FN % 10 == 6 && x.FN % 100 == 6)
                                        .Select(x => new { Marks = string.Join(", ", x.Marks) });

            Console.WriteLine("All marks of students in 2006:\n\n{0}", string.Join("\n", result));
            Console.WriteLine("==============================================\n");
        }

        public static void ExtractStudentsWithTwoMarks(List<Student> listOfStudents)
        {
            var result = listOfStudents
                .Where(x => x.Marks.Count(y => y == 2) == 2 ? true : false)
                .Select(x => new { FirstName = x.FirstName, Marks = string.Join(", ", x.Marks) });

            Console.WriteLine("Students with exactly two marks 2:\n\n{0}", string.Join("\n", result));
            Console.WriteLine("==============================================\n");
        }

        public static void ExtractStudentsByMarks(List<Student> listOfStudents)
        {
            var result = from student in listOfStudents
                         where student.Marks.Contains(6)
                         select new { FirstName = student.FirstName, Marks = string.Join(", ", student.Marks) };

            Console.WriteLine("Students with atleast one mark Excellent (6):\n\n{0}", string.Join("\n", result));
            Console.WriteLine("==============================================\n");
        }

        public static void ExtractStudentsByPhone(List<Student> listOfStudents)
        {
            var result = from student in listOfStudents
                         where student.Tel.StartsWith("+3592")
                         select student;
            Console.WriteLine("Students with phone in Sofia:\n\n{0}", string.Join("\n", result));
            Console.WriteLine("==============================================\n");
        }

        public static void ExtractStudentsByEmail(List<Student> listOfStudents)
        {
            var result = from student in listOfStudents
                         where student.Email.EndsWith("@abv.bg")
                         select student;
            Console.WriteLine("Students with email in abv.bg:\n\n{0}", string.Join("\n", result));
            Console.WriteLine("==============================================\n");
        }

        public static void SortStudentsFromGroupTwoWithExtensionMethods(List<Student> listOfStudents)
        {
            var sortedStudentsWithExtensionMethods = listOfStudents
                                                                    .Where(x => x.Group.GroupNumber == 2)
                                                                    .OrderBy(x => x.FirstName);

            Console.WriteLine("Sorted students in group #2 with extension methods:\n\n{0}", string.Join("\n", sortedStudentsWithExtensionMethods));
            Console.WriteLine("==============================================\n");
        }

        public static void SortStudentsInGroupTwoWithLinq(List<Student> listOfStudents)
        {
            var sortedStudentsFromGroupTwo = from student in listOfStudents
                                             where student.Group.GroupNumber == 2
                                             orderby student.FirstName
                                             select student;

            Console.WriteLine("Sorted students in group #2 with LINQ:\n\n{0}", string.Join("\n", sortedStudentsFromGroupTwo));
            Console.WriteLine("==============================================\n");
        }

        public static List<Student> InitializeList()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Pesho", "Ivanov", 123406, "+3592 88 88 88", "asdf@gmail.com", new List<int>() { 3, 3, 3, 5 }, new Group(3, "Mathematics")));
            listOfStudents.Add(new Student("Pesho", "Petkov", 124406, "+359888 888 999", "asdf1@gmail.com", new List<int>() { 2, 2, 3, 5 }, new Group(2, "Electronics")));
            listOfStudents.Add(new Student("Ivan", "Ivanov", 123458, "+359888 888 000", "asdf2@gmail.com", new List<int>() { 2, 5, 3, 5 }, new Group(3, "Mathematics")));
            listOfStudents.Add(new Student("Gosho", "Peshov", 123459, "+359888 888 777", "asdf3@abv.bg", new List<int>() { 3, 6, 3, 5, 6 }, new Group(2, "Electronics")));
            listOfStudents.Add(new Student("Gosho", "Goshov", 123460, "+359888 888 111", "asdf4@abv.bg", new List<int>() { 3, 6, 6, 5, 6 }, new Group(1, "Telecomunications")));

            return listOfStudents;
        }
    }
}

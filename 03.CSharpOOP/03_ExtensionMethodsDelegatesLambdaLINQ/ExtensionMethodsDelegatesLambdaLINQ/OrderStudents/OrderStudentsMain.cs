namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderStudentsMain
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Pesho", "Ivanov", 17));
            listOfStudents.Add(new Student("Pesho", "Goshov", 19));
            listOfStudents.Add(new Student("Gosho", "Peshov", 21));
            listOfStudents.Add(new Student("Gosho", "Ivanov", 23));
            listOfStudents.Add(new Student("Haralampi", "Genadiev", 25));

            var resultWithExtensionMethods = listOfStudents
                                             .OrderByDescending(x => x.FirstName)
                                             .ThenByDescending(x => x.LastName);

            Console.WriteLine("List of students:\n{0}\n\nList of sorted students with methods:\n{1}", string.Join("\n", listOfStudents), string.Join("\n", resultWithExtensionMethods));

            var resultWithQueryes = from student in listOfStudents
                                    orderby student.FirstName descending, student.LastName descending
                                    select student;                                    

            Console.WriteLine("\nList of students:\n{0}\n\nList of sorted students with LINQ:\n{1}", string.Join("\n", listOfStudents), string.Join("\n", resultWithQueryes));
        }
    }
}

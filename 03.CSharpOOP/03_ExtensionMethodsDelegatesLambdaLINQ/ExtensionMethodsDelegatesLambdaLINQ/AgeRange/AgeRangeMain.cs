namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AgeRangeMain
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Pesho", "Ivanov", 17));
            listOfStudents.Add(new Student("Pesho", "Goshov", 19));
            listOfStudents.Add(new Student("Gosho", "Peshov", 21));
            listOfStudents.Add(new Student("Gosho", "Ivanov", 23));
            listOfStudents.Add(new Student("Haralampi", "Genadiev", 25));

            var reslutListOfStudents = FindStudentsInAgeRange(listOfStudents, 18, 24);

            Console.WriteLine("List of students:\n{0}\nList of student with age in range 18-24:\n{1}", string.Join("\n", listOfStudents), string.Join("\n", reslutListOfStudents));
        }

        private static List<string> FindStudentsInAgeRange(List<Student> listOfStudents, int min, int max)
        {
            var resultList = from student in listOfStudents
                             where student.Age > min && student.Age < max
                             select Convert.ToString(student.FirstName + " " + student.LastName);

            return resultList.ToList();
        }
    }
}

namespace FirstBeforLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstBeforeLastMain
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Pesho", "Ivanov"));
            listOfStudents.Add(new Student("Pesho", "Goshov"));
            listOfStudents.Add(new Student("Gosho", "Peshov"));
            listOfStudents.Add(new Student("Gosho", "Ivanov"));
            listOfStudents.Add(new Student("Haralampi", "Genadiev"));

            List<Student> resultListOfStudents = FindFirstBeforeLast(listOfStudents);

            Console.WriteLine("List of students:\n{0}\n\nList of students with first name before last name alphabetically:\n{1}", string.Join("\n", listOfStudents), string.Join("\n", resultListOfStudents));
        }

        private static List<Student> FindFirstBeforeLast(List<Student> input)
        {
            IEnumerable<Student> listOfStudents = from item in input
                                                  where item.FirstName.CompareTo(item.LastName) < 0
                                                  select new Student(item.FirstName, item.LastName);

            /// List<Student> listOfStudents = input.Where(x => x.FirstName.CompareTo(x.LastName) < 0 ? true : false).ToList();

            return listOfStudents.ToList();
        }
    }
}

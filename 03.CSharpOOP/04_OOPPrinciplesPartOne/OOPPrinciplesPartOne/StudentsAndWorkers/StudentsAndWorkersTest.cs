namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersTest
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Pesho", "Peshov", 6));
            listOfStudents.Add(new Student("Pesho", "Ivanov", 6));
            listOfStudents.Add(new Student("Ivan", "Ivanov", 2));
            listOfStudents.Add(new Student("Ivan", "Peshov", 3));
            listOfStudents.Add(new Student("Gosho", "Peshov", 1));
            listOfStudents.Add(new Student("Gosho", "Goshov", 4));
            listOfStudents.Add(new Student("Gosho", "Ivanov", 2));
            listOfStudents.Add(new Student("Pesho", "Goshov", 4));
            listOfStudents.Add(new Student("Ivan", "Goshov", 5));
            listOfStudents.Add(new Student("Haralampi", "Goshov", 7));

            /// Sort the list of students.
            List<Student> sortedListOfStudents = listOfStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine("Sorted list of students:\n");
            foreach (var student in sortedListOfStudents)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> listOfWorkers = new List<Worker>();

            listOfWorkers.Add(new Worker("Hristo", "Hristov", 500, 8));
            listOfWorkers.Add(new Worker("Hristo", "Goshov", 600, 8));
            listOfWorkers.Add(new Worker("Gosho", "Hristov", 700, 8));
            listOfWorkers.Add(new Worker("Hristo", "Ivanov", 800, 8));
            listOfWorkers.Add(new Worker("Ivan", "Hristov", 900, 8));
            listOfWorkers.Add(new Worker("Pesho", "Hristov", 1000, 8));
            listOfWorkers.Add(new Worker("Haralampi", "Hristov", 1100, 8));
            listOfWorkers.Add(new Worker("Haralampi", "Ivanov", 1200, 8));
            listOfWorkers.Add(new Worker("Gencho", "Hristov", 1300, 8));
            listOfWorkers.Add(new Worker("Gencho", "Genchov", 1400, 8));

            /// Sort the list of workers.
            List<Worker> sortedListOfWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            Console.WriteLine("Sorted list of workers:\n");
            foreach (var worker in sortedListOfWorkers)
            {
                Console.WriteLine(worker.ToString());
            }

            List<Human> mergedList = new List<Human>();

            MergeListsOfHumans(mergedList, listOfStudents, listOfWorkers);

            List<Human> sortedMergedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine("Sorted merged list:\n");
            foreach (var human in sortedMergedList)
            {
                Console.WriteLine(human.ToString());
            }
        }

        private static void MergeListsOfHumans(List<Human> mergedList, List<Student> listOfStudents, List<Worker> listOfWorkers)
        {
            foreach (var student in listOfStudents)
            {
                mergedList.Add(student);
            }

            foreach (var worker in listOfWorkers)
            {
                mergedList.Add(worker);
            }
        }
    }
}

namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentGroup;

    /*
     Problems 18 and 19.
     */

    public class GroupMain
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = StudentGroup.StudentMain.InitializeList();

            /// Group students using LINQ.
            GroupByNumberWithLINQ(listOfStudents);

            /// Group students using extension methods.
            GroupByNumberWithExtensions(listOfStudents);
        }

        private static void GroupByNumberWithExtensions(List<Student> listOfStudents)
        {
            var groupedStudents = listOfStudents.GroupBy(x => x.Group.GroupNumber);

            Console.WriteLine("Grouped students by student's groupe number with Extension methods:\n\n");

            foreach (var item in groupedStudents)
            {
                Console.WriteLine(string.Join("\n", item));
            }
        }

        private static void GroupByNumberWithLINQ(List<Student> listOfStudents)
        {
            var groupedStudents = from student in listOfStudents
                                  group student by student.Group.GroupNumber;

            Console.WriteLine("Grouped students by student's groupe number with LINQ:\n\n");

            foreach (var item in groupedStudents)
            {
                Console.WriteLine(string.Join("\n", item));
            }
        }
    }
}

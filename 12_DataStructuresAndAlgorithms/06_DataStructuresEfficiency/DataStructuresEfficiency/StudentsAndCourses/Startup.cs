namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var text = new StreamReader("../../students.txt");

            var currentLine = text.ReadLine();

            SortedDictionary<string, List<Student>> studentsInCourses = new SortedDictionary<string, List<Student>>();

            while (currentLine != null)
            {
                var rowParts = currentLine.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string course = rowParts[2];
                Student student = new Student
                {
                    FirstName = rowParts[0].Trim(),
                    LastName = rowParts[1].Trim()
                };

                if (!studentsInCourses.ContainsKey(course))
                {
                    studentsInCourses[course] = new List<Student>();
                }

                studentsInCourses[course].Add(student);

                currentLine = text.ReadLine();
            }

            foreach (var pair in studentsInCourses)
            {
                Console.WriteLine(
                    string.Format("{0}: {1}",
                        pair.Key,
                        string.Join(", ",
                            pair.Value
                                .OrderBy(s => s.LastName)
                                .ThenBy(s => s.FirstName))));
            }
        }
    }
}

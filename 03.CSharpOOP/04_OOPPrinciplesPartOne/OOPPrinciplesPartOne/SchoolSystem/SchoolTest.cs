namespace SchoolSystem
{
    using System.Collections.Generic;

    using SchoolSystem.Persons;

    public class SchoolTest
    {
        public static void Main(string[] args)
        {
            Discipline mathematic = new Discipline("Mathematic", 10, 10);
            Discipline courseCSharpPartOne = new Discipline("C# Part One", 6, 1);
            Discipline courseCSharpPartTwo = new Discipline("C# Part Two", 9, 2);

            List<Discipline> peshosListOfDisciplines = IninializeListOfDisciplines(mathematic, courseCSharpPartOne, courseCSharpPartTwo);

            List<Discipline> goshosListOfDisciplines = IninializeListOfDisciplines(courseCSharpPartOne, courseCSharpPartTwo);

            Teacher teacherPesho = new Teacher("Pesho", peshosListOfDisciplines);
            Teacher teacherGosho = new Teacher("Gosho", goshosListOfDisciplines);

            List<Teacher> listOfTeachers = new List<Teacher>();

            listOfTeachers.Add(teacherPesho);
            listOfTeachers.Add(teacherGosho);

            Student studentGencho = new Student("Gencho", 1);
            Student studentPencho = new Student("Pencho", 1);

            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(studentGencho);
            listOfStudents.Add(studentPencho);

            Class firstClass = new Class("First class identifier", listOfStudents, listOfTeachers);

            List<Class> listOfClasses = new List<Class>();

            listOfClasses.Add(firstClass);

            School epicSchool = new School(listOfClasses);

            System.Console.WriteLine(epicSchool.ToString());
        }

        private static List<Discipline> IninializeListOfDisciplines(params Discipline[] disciplines)
        {
            List<Discipline> listOfDisciplines = new List<Discipline>();

            foreach (var discipline in disciplines)
            {
                listOfDisciplines.Add(discipline);
            }

            return listOfDisciplines;
        }
    }
}

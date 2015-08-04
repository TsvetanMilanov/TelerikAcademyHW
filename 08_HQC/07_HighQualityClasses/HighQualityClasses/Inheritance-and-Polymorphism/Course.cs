namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {
        private const int MinCourseNameLength = 3;
        private const int MaxCourseNameLength = 65;
        private const int MinFullNameLength = 4;
        private const int MaxFullNameLength = 35;
        private const int MinStudentNameLength = 3;
        private const int MaxStudentNameLength = 15;

        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckStringLength(value, MinCourseNameLength, MaxCourseNameLength, "Course name");

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                Validator.CheckStringLength(value, MinFullNameLength, MaxFullNameLength, "Teachers name");

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                IList<string> clonedListOfStudents = this.students.ToList();

                return clonedListOfStudents;
            }

            protected set
            {
                Validator.CheckListLength(value, "List of students");

                foreach (var student in value)
                {
                    Validator.CheckStringLength(
                        student,
                        MinStudentNameLength,
                        MaxStudentNameLength,
                        "Students name");
                }

                this.students = value;
            }
        }

        public void AddStudents(string student)
        {
            Validator.CheckStringLength(student, MinFullNameLength, MaxFullNameLength, "Students name");

            this.students.Add(student);
        }

        public void AddStudents(IList<string> studentsToAdd)
        {
            for (int i = 0; i < studentsToAdd.Count; i++)
            {
                string currentStudent = studentsToAdd[i];
                Validator.CheckStringLength(currentStudent, MinFullNameLength, MaxFullNameLength, "Students name");

                this.students.Add(currentStudent);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ Name = ");
            result.Append(this.Name);

            result.Append("; Teacher = ");
            result.Append(this.TeacherName);

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append("; ");

            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}

namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        private const int MaxStudentsInCourse = 29;
        private IList<Student> listOfStudents;

        public Course()
        {
            this.ListOfStudents = new List<Student>();
        }

        public Course(IList<Student> listOfStudents)
        {
            this.ListOfStudents = listOfStudents;
        }

        public IList<Student> ListOfStudents
        {
            get
            {
                return this.listOfStudents.ToList();
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Courses list of students must not be null!");
                }

                this.listOfStudents = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to be added must not be null!");
            }

            if (this.ListOfStudents.Count == MaxStudentsInCourse)
            {
                throw new InvalidOperationException("Student was not added because the course is full!");
            }

            this.listOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to be removed must not be null!");
            }

            if (!this.ListOfStudents.Contains(student))
            {
                throw new InvalidOperationException("Can't remove student that is not in this course!");
            }

            this.listOfStudents.Remove(student);
        }
    }
}

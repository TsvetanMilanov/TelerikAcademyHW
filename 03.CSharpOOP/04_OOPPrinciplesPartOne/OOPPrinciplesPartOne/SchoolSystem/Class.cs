namespace SchoolSystem
{
    using System.Collections.Generic;

    using SchoolSystem.Persons;

    public class Class : ICommentable
    {
        public Class()
        {
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public Class(string inputIdentifier, List<Student> inputStudents, List<Teacher> inputTeachers)
            : this()
        {
            this.Identifier = inputIdentifier;
            this.Students = inputStudents;
            this.Teachers = inputTeachers;
        }

        public string Identifier { get; private set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Class identifier: {0}\nStudents in this class:\n{1}\nTeachers in this class:\n{2}\nComment for this class: {3}\n", this.Identifier, string.Join("\n", this.Students), string.Join("\n", this.Teachers), this.Comment);
        }
    }
}

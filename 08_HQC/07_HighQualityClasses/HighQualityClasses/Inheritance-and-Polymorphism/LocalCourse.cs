namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public LocalCourse(string courseName, string teacherName, string lab)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, string lab, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse ");
            result.Append(base.ToString());
            result.Append("Lab = ");
            result.Append(this.Lab);
            result.Append(" }");

            return result.ToString();
        }
    }
}

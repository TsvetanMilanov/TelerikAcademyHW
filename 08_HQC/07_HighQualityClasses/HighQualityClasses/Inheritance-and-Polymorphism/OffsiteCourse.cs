namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private const int MinTownNameLength = 2;
        private const int MaxTownNameLength = 30;

        private string town;

        public OffsiteCourse(string courseName, string teacherName, string town)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, string town, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                Validator.CheckStringLength(value, MinTownNameLength, MaxTownNameLength, "Towns name");

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse ");
            result.Append(base.ToString());
            result.Append("Town = ");
            result.Append(this.Town);
            result.Append(" }");

            return result.ToString();
        }
    }
}

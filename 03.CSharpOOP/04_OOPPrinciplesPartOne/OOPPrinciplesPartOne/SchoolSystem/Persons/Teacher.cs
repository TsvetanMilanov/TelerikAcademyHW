namespace SchoolSystem.Persons
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        public Teacher(string inputName, List<Discipline> inputDisciplines)
            : base(inputName)
        {
            this.Disciplines = inputDisciplines;
        }

        public List<Discipline> Disciplines { get; set; }

        public override string ToString()
        {
            return string.Format("Teacher name: {0}\nList of disciplines:\n{1}\nComment for this teacher: {2}\n", this.Name, string.Join("\n", this.Disciplines), this.Comment);
        }
    }
}

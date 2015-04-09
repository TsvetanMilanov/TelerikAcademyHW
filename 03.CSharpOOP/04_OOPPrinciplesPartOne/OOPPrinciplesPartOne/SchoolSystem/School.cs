namespace SchoolSystem
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Classes = new List<Class>();
        }

        public School(List<Class> inputClasses)
            : this()
        {
            this.Classes = inputClasses;
        }

        public List<Class> Classes { get; set; }

        public override string ToString()
        {
            return string.Format("The school has classes\n{0}", string.Join("\n", this.Classes));
        }
    }
}

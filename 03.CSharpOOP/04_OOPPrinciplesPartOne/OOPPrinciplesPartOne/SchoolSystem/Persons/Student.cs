namespace SchoolSystem.Persons
{
    public class Student : Person, ICommentable
    {
        public Student(string inputName, int inputClassNumber)
            : base(inputName)
        {
            this.ClassNumber = inputClassNumber;
        }

        public int ClassNumber { get; private set; }

        public override string ToString()
        {
            return string.Format("Student name: {0}\nClass number: {1}\nComment for this student: {2}\n", this.Name, this.ClassNumber, this.Comment);
        }
    }
}

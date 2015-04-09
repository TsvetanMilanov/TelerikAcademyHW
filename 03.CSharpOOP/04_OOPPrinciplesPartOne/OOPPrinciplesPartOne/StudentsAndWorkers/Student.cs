namespace StudentsAndWorkers
{
    public class Student : Human
    {
        public Student(string inputFirstName, string inputLastName, int inputGrade)
            : base(inputFirstName, inputLastName)
        {
            this.Grade = inputGrade;
        }

        public int Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0}Grade: {1}\n", base.ToString(), this.Grade);
        }
    }
}

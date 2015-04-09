namespace StudentGroup
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string inputFirstName, string inputLastName, int inputFN, string inputTel, string inputEmail, List<int> inputMarks, Group inputGroup)
        {
            this.FirstName = inputFirstName;
            this.LastName = inputLastName;
            this.FN = inputFN;
            this.Tel = inputTel;
            this.Email = inputEmail;
            this.Marks = inputMarks;
            this.Group = inputGroup;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFN: {2}\nTel: {3}\nEmail: {4}\nMarks: {5}\nGroup: {6}\n", this.FirstName, this.LastName, this.FN, this.Tel, this.Email, string.Join(", ", this.Marks), this.Group);
        }
    }
}

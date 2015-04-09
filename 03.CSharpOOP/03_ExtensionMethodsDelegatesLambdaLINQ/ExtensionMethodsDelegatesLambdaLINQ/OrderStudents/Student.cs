namespace OrderStudents
{
    public class Student
    {
        public Student(string inputFirstName, string inputLastName, int inputAge)
        {
            this.FirstName = inputFirstName;
            this.LastName = inputLastName;
            this.Age = inputAge;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " Age: " + this.Age;
        }
    }
}

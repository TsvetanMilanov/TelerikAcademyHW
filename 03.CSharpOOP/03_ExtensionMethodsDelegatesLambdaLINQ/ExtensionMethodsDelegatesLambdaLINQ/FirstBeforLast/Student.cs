namespace FirstBeforLast
{
    public class Student
    {
        public Student(string inputFirstName, string inputLastName)
        {
            this.FirstName = inputFirstName;
            this.LastName = inputLastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        public Human(string inputFirstName, string inputLastName)
        {
            this.FirstName = inputFirstName;
            this.LastName = inputLastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\n", this.FirstName, this.LastName);
        }
    }
}

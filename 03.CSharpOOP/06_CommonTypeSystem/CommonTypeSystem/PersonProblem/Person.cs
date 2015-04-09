namespace PersonProblem
{
    public class Person
    {
        public Person(string personName)
        {
            this.Name = personName;
        }

        public Person(string personName, int? personAge)
            : this(personName)
        {
            this.Age = personAge;
        }

        public string Name { get; set; }

        public int? Age { get; set; }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}\nAge: null", this.Name);
            }

            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age);
        }
    }
}

namespace VisitorPattern
{
    public abstract class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
            this.Efficiency = 10;
        }

        public string Name { get; set; }

        public int Efficiency { get; set; }

        public abstract void AcceptVisitor(IVisitor visitor);

        public string Report()
        {
            string report = string.Format("I am {0} and my efficiency is: {1}%!", this.Name, this.Efficiency);

            return report;
        }
    }
}
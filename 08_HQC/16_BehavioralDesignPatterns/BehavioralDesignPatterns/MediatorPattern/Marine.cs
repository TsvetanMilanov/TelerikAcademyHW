namespace MediatorPattern
{
    public class Marine : ISoldier
    {
        public Marine(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Position { get; set; }

        public string Report()
        {
            string report = string.Format("I am {0} and my position is: {1}", this.Name, this.Position);

            return report;
        }
    }
}

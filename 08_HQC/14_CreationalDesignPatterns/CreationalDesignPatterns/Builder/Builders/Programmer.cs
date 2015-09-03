namespace Builder.Builders
{
    public abstract class Programmer
    {
        public Programmer()
        {
            this.Application = new Application();
        }

        public Application Application { get; set; }

        public abstract void DesignApplication();

        public abstract void WriteCode();

        public abstract void RunUnitTests();

        public abstract void FixBugs();
    }
}

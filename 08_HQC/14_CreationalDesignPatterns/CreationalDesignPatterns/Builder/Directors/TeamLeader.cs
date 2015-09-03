namespace Builder.Directors
{
    using Builders;

    public class TeamLeader : Director
    {
        public override Application CreateApplication(Programmer programmer)
        {
            programmer.DesignApplication();
            programmer.WriteCode();
            programmer.RunUnitTests();
            programmer.FixBugs();

            return programmer.Application;
        }
    }
}

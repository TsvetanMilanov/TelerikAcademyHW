namespace Builder.Directors
{
    using Builders;

    public abstract class Director
    {
        public abstract Application CreateApplication(Programmer programmer);
    }
}

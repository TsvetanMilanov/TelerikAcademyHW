namespace FactoryMethod.Factories
{
    using Computers;

    public abstract class Factory
    {
        public abstract Computer CreateComputer();
    }
}

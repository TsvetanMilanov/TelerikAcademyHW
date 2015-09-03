namespace AbstractFactory.Factories
{
    using Products;

    public abstract class Factory
    {
        public abstract MobilePhone CreateMobilePhone();

        public abstract Speakers CreateSpeakers();

        public abstract TelevisionSet CreateTelevisionSet();
    }
}

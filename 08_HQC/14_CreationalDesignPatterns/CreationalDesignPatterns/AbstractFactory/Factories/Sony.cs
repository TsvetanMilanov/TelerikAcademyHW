namespace AbstractFactory.Factories
{
    using Products;

    public class Sony : Factory
    {
        public override MobilePhone CreateMobilePhone()
        {
            MobilePhone sonyMobilePhone = new MobilePhone("High");

            return sonyMobilePhone;
        }

        public override Speakers CreateSpeakers()
        {
            Speakers sonySpeakers = new Speakers(true);

            return sonySpeakers;
        }

        public override TelevisionSet CreateTelevisionSet()
        {
            TelevisionSet sonyTelevisionSet = new TelevisionSet(60);

            return sonyTelevisionSet;
        }
    }
}

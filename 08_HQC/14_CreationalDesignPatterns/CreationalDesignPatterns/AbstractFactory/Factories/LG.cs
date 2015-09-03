namespace AbstractFactory.Factories
{
    using Products;

    public class LG : Factory
    {
        public override MobilePhone CreateMobilePhone()
        {
            MobilePhone lgMobilePhone = new MobilePhone("Medium");

            return lgMobilePhone;
        }

        public override Speakers CreateSpeakers()
        {
            Speakers lgSpeakers = new Speakers(false);

            return lgSpeakers;
        }

        public override TelevisionSet CreateTelevisionSet()
        {
            TelevisionSet lgTelevisionSet = new TelevisionSet(40);

            return lgTelevisionSet;
        }
    }
}

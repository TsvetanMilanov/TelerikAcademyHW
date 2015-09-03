namespace AbstractFactory
{
    using System;
    using Factories;

    public class AbstractFactoryEntryPoint
    {
        public static void Main(string[] args)
        {
            Factory sony = new Sony();
            Factory lg = new LG();

            Console.WriteLine("Sony products:");
            PrintProductsOfFactory(sony);

            Console.WriteLine("\nLG products:");
            PrintProductsOfFactory(lg);
        }

        private static void PrintProductsOfFactory(Factory factory)
        {
            Console.WriteLine(factory.CreateMobilePhone().GetInformation());

            Console.WriteLine(factory.CreateSpeakers().GetInformation());

            Console.WriteLine(factory.CreateTelevisionSet().GetInformation());
        }
    }
}

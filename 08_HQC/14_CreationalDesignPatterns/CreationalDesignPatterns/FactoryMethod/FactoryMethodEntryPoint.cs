namespace FactoryMethod
{
    using System;
    using Computers;
    using Factories;

    public class FactoryMethodEntryPoint
    {
        public static void Main(string[] args)
        {
            Factory standardFactory = new StandardComputersFactory();
            Factory laptopFactory = new LaptopsFacoty();

            Computer standardComputer = standardFactory.CreateComputer();
            Computer laptop = laptopFactory.CreateComputer();

            Console.WriteLine(standardComputer.GetInformation());
            Console.WriteLine(laptop.GetInformation());
        }
    }
}

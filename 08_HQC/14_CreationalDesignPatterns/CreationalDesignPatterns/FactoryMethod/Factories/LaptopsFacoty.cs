namespace FactoryMethod.Factories
{
    using System.Collections.Generic;

    using Computers;

    public class LaptopsFacoty : Factory
    {
        public override Computer CreateComputer()
        {
            IDictionary<string, string> parts = new Dictionary<string, string>
            {
                { "Motherboard", "HP" },
                { "Monitor", "HP" },
                { "HDD", "HP" },
                { "Graphic card", "HP" }
            };

            Computer laptop = new Laptop(parts);

            return laptop;
        }
    }
}

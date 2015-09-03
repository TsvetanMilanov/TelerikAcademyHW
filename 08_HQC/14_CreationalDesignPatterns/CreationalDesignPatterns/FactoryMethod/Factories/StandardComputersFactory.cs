namespace FactoryMethod.Factories
{
    using System.Collections.Generic;

    using Computers;

    public class StandardComputersFactory : Factory
    {
        public override Computer CreateComputer()
        {
            IDictionary<string, string> parts = new Dictionary<string, string>
            {
                { "Motherboard", "Gigabyte" },
                { "Monitor", "LG" },
                { "HDD", "Westgate" },
                { "Graphic card", "nVidia" }
            };

            Computer standardComputer = new StandardComputer(parts);

            return standardComputer;
        }
    }
}

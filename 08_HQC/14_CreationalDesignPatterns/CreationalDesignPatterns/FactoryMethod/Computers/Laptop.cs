namespace FactoryMethod.Computers
{
    using System.Collections.Generic;

    internal class Laptop : Computer
    {
        public Laptop(IDictionary<string, string> parts)
            : base(parts)
        {
        }

        public override string GetInformation()
        {
            string baseInformation = base.GetInformation();

            string computerType = "Laptop: \n";

            return computerType + baseInformation;
        }
    }
}
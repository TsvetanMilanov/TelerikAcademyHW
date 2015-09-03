namespace FactoryMethod.Computers
{
    using System.Collections.Generic;

    internal class StandardComputer : Computer
    {
        public StandardComputer(IDictionary<string, string> parts)
            : base(parts)
        {
        }

        public override string GetInformation()
        {
            string baseInformation = base.GetInformation();

            string computerType = "Standard computer: \n";

            return computerType + baseInformation;
        }
    }
}
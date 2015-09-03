namespace FactoryMethod.Computers
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Computer
    {
        public Computer(IDictionary<string, string> parts)
        {
            this.Parts = parts;
        }

        public IDictionary<string, string> Parts { get; set; }

        public virtual string GetInformation()
        {
            StringBuilder information = new StringBuilder();

            foreach (var part in this.Parts)
            {
                information.AppendFormat("{0} ---> {1}", part.Key, part.Value);
                information.AppendLine();
            }

            return information.ToString();
        }
    }
}
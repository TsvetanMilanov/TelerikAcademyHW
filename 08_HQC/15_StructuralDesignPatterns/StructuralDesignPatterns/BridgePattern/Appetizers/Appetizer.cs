namespace BridgePattern.Appetizers
{
    public abstract class Appetizer
    {
        public Appetizer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual string Eat()
        {
            return string.Format("Eating {0}", this.Name);
        }
    }
}

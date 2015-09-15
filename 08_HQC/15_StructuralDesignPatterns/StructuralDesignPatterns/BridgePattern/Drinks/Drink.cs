namespace BridgePattern.Drinks
{
    using System;

    using BridgePattern.Appetizers;

    public abstract class Drink
    {
        public Drink(string brand, int quantity, Appetizer appetizer)
        {
            this.Brand = brand;
            this.Quantity = quantity;
            this.Appetizer = appetizer;
        }

        public int Quantity { get; set; }

        public string Brand { get; set; }

        public Appetizer Appetizer { get; set; }

        public virtual void DisplayInformation()
        {
            Console.WriteLine("Drink: {0}", this.Brand);
            Console.WriteLine("Quantity: {0} ml.", this.Quantity);
            Console.WriteLine("Appetizer: {0}", this.Appetizer.Eat());
        }
    }
}

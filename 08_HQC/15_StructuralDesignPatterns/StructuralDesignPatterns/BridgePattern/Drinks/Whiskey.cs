namespace BridgePattern.Drinks
{
    using BridgePattern.Appetizers;

    public class Whiskey : Drink
    {
        public Whiskey(string name, int quantity, Appetizer appetizer)
            : base(name, quantity, appetizer)
        {
        }
    }
}

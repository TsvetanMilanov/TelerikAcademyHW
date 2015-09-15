namespace BridgePattern
{
    using System;

    using Appetizers;
    using Drinks;

    public class EntryPoint
    {
        public static void Main()
        {
            Appetizer almonds = new Almond();
            Appetizer cashew = new Cashew();
            Appetizer peanuts = new Peanut();

            Drink whiskey = new Whiskey("Johny Walker", 50, cashew);

            Console.WriteLine("--------- Drink with cashew appetizer:");
            whiskey.DisplayInformation();
            Console.WriteLine();

            whiskey.Appetizer = almonds;
            Console.WriteLine("--------- Drink with almonds appetizer:");
            whiskey.DisplayInformation();
            Console.WriteLine();

            whiskey.Appetizer = peanuts;
            Console.WriteLine("--------- Drink with peanuts appetizer:");
            whiskey.DisplayInformation();
            Console.WriteLine();
        }
    }
}

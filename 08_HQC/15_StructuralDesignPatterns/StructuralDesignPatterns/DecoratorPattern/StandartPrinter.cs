namespace DecoratorPattern
{
    using System;

    public class StandartPrinter : IPrinter
    {
        public void Print(string key, string value)
        {
            Console.WriteLine("{0} - {1}", key, value);
        }
    }
}

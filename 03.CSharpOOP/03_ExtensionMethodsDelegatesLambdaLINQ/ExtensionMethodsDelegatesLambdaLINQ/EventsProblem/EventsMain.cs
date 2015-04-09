namespace EventsProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EventsMain
    {
        public static void Main(string[] args)
        {
            SimpleList testList = new SimpleList();

            testList.SomeChange += AddedNumber;

            testList.AddNumber(5);
            testList.AddNumber(7);
            testList.AddNumber(9);
        }

        private static void AddedNumber(object sender, EventArgs e)
        {
            Console.WriteLine("Added number to the simple list test list.");
        }
    }
}

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DivisibleMain
    {
        public static void Main(string[] args)
        {
            int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Console.WriteLine("With extension methods: {0}", string.Join(", ", arrayOfIntegers.Where(x => x % 7 == 0 || x % 3 == 0).ToArray()));

            Console.WriteLine("With LINQ: {0}", string.Join(", ", from number in arrayOfIntegers where number % 7 == 0 || number % 3 == 0 select number));
        }
    }
}

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 1, 52, -2, 2, 953, -2, 5, -156, 7, 7, -7, 4, 6, -6, 875, -7, 547 };

            IList<int> sequenceWithPositiveNumbers = RemoveNegativeNumbers(sequence);

            Console.WriteLine("The sequence without the negative numbers is:");
            Console.WriteLine(string.Join(", ", sequenceWithPositiveNumbers));
        }

        private static IList<int> RemoveNegativeNumbers(List<int> sequence)
        {
            var positiveNumbers = new List<int>();

            foreach (var number in sequence)
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            return positiveNumbers;
        }
    }
}

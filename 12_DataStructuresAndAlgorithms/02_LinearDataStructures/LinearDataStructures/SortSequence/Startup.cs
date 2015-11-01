namespace SortSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // var sequence = new List<int> { 1, 52, 2, 844, 953, 2, 5, 156, 7, 125, 36, 4, 874, 6, 875, 7, 547 };

            var sequence = ReadNumbersFromConsole();

            IList<int> sortedSequence = BubbleSort(sequence);

            Console.WriteLine("The sorted sequence is:");
            Console.WriteLine(string.Join(",", sortedSequence));
        }

        private static IList<int> ReadNumbersFromConsole()
        {
            Console.Write("Enter number: ");
            string currentLine = Console.ReadLine();
            IList<int> sequence = new List<int>();

            while (!string.IsNullOrWhiteSpace(currentLine))
            {
                int currentNumber = int.Parse(currentLine);

                sequence.Add(currentNumber);

                Console.Write("Enter number: ");
                currentLine = Console.ReadLine();
            }

            return sequence;
        }

        private static IList<int> BubbleSort(IList<int> sequence)
        {
            var sortedSequence = sequence.ToList();

            for (int i = 0; i < sortedSequence.Count; i++)
            {
                for (int j = 0; j < sortedSequence.Count - 1; j++)
                {
                    if (sortedSequence[j] > sortedSequence[j + 1])
                    {
                        int oldValue = sortedSequence[j + 1];
                        sortedSequence[j + 1] = sortedSequence[j];
                        sortedSequence[j] = oldValue;
                    }
                }
            }

            return sortedSequence;
        }
    }
}

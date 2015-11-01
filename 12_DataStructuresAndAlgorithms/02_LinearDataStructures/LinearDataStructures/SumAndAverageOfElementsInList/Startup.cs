namespace SumAndAverageOfElementsInList
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
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

            int sum = SumNumbersInSequence(sequence);
            float average = FindAverageOfSequence(sequence);

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", average);
        }

        private static int SumNumbersInSequence(IList<int> sequence)
        {
            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }

        private static float FindAverageOfSequence(IList<int> sequence)
        {
            float average = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                average += sequence[i];
            }

            average /= sequence.Count;

            return average;
        }
    }
}

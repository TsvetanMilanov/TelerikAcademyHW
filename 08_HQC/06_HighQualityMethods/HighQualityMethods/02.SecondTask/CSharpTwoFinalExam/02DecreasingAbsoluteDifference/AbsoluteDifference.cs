namespace Sequence
{
    using System;
    using System.Linq;

    public class AbsoluteDifference
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            long[][] sequence = new long[linesCount][];

            for (int i = 0; i < linesCount; i++)
            {
                sequence[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            long[][] differences = CalculateDifferences(sequence);

            foreach (var difference in differences)
            {
                bool isSequenceOfDifferencesIsDecreasing = CheckIfSequenceIsDecreasing(difference);

                if (isSequenceOfDifferencesIsDecreasing)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        private static long[][] CalculateDifferences(long[][] sequence)
        {
            int sequenceLength = sequence.GetLength(0);
            long[][] differences = new long[sequenceLength][];

            for (int i = 0; i < sequence.GetLength(0); i++)
            {
                int currentSequenceLength = sequence[i].GetLength(0);
                differences[i] = new long[currentSequenceLength - 1];
                for (int j = 0; j < currentSequenceLength; j++)
                {
                    if (j < currentSequenceLength - 1)
                    {
                        long firstNumber = Math.Max(sequence[i][j], sequence[i][j + 1]);
                        long secondNumber = Math.Min(sequence[i][j], sequence[i][j + 1]);

                        long currentDifference = firstNumber - secondNumber;

                        differences[i][j] = currentDifference;
                    }
                }
            }

            return differences;
        }

        private static bool CheckIfSequenceIsDecreasing(long[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < sequence.Length - 1)
                {
                    long firstNumber = sequence[i];
                    long secondNumber = sequence[i + 1];
                    long difference = firstNumber - secondNumber;

                    if (difference < 0 || difference >= 2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

namespace RemoveNumbersWithOddOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            IList<int> proccessedSequence = RemoveNumbersWithOddOccurances(sequence);

            Console.WriteLine("The proccesed sequence is:");
            Console.WriteLine(string.Join(", ", proccessedSequence));
        }

        private static IList<int> RemoveNumbersWithOddOccurances(List<int> sequence)
        {
            var result = sequence.ToList();
            IDictionary<int, IList<int>> histogram = new Dictionary<int, IList<int>>();

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentElement = sequence[i];

                if (!histogram.ContainsKey(currentElement))
                {
                    histogram[currentElement] = new List<int>();
                }

                histogram[currentElement].Add(i);
            }

            foreach (var item in histogram)
            {
                var indexes = item.Value;

                if (indexes.Count % 2 != 0 && indexes.Count > 0)
                {
                    result.RemoveAll(n => n == item.Key);
                }
            }

            return result;
        }
    }
}

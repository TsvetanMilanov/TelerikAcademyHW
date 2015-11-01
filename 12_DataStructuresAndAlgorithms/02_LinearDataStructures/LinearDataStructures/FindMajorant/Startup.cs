namespace FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var numbersWithOccurances = FindOccurances(sequence);

            var majorant = numbersWithOccurances.FirstOrDefault(p => p.Value >= sequence.Count / 2 + 1);

            if (majorant.Equals(default(KeyValuePair<int, int>)))
            {
                Console.WriteLine("There is no majorant in this sequence!");
            }
            else
            {
                Console.WriteLine(
                    "The majorant in the sequence {{{0}}} is: {1} -> {2} times.",
                    string.Join(", ", sequence),
                    majorant.Key,
                    majorant.Value);
            }
        }

        private static IDictionary<int, int> FindOccurances(List<int> sequence)
        {
            var numbersWithOccurances = new Dictionary<int, int>();

            foreach (var number in sequence)
            {
                if (!numbersWithOccurances.ContainsKey(number))
                {
                    numbersWithOccurances[number] = 0;
                }

                numbersWithOccurances[number] += 1;
            }

            return numbersWithOccurances;
        }
    }
}

namespace FindOccurances
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            IDictionary<int, int> numbersWithOccurances = FindOccurances(sequence);

            Console.WriteLine("Occurances:");
            foreach (var pair in numbersWithOccurances)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
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

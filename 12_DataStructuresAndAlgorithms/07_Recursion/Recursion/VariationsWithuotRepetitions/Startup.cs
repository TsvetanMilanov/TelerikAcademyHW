namespace CombinationsOfSubsets
{
    using System;

    public class Startup
    {
        private static string[] set = { "test", "rock", "fun" };
        private static string[] combination;

        public static void Main()
        {
            int n = set.Length;

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            combination = new string[k];

            FindCombinations(n, k, 0, 0);
        }

        private static void FindCombinations(int n, int k, int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", combination));

                return;
            }

            for (int i = start; i < n; i++)
            {
                combination[index] = set[i];
                FindCombinations(n, k, index + 1, i + 1);
            }
        }
    }
}

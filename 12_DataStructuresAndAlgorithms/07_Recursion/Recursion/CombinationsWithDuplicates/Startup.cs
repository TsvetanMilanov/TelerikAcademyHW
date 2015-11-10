namespace CombinationsWithDuplicates
{
    using System;

    public class Startup
    {
        private static int[] combination;

        public static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            combination = new int[k];

            FindCombinations(n, k, 0, 0);
        }

        private static void FindCombinations(int n, int k, int start, int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", combination));

                return;
            }

            for (int i = start; i < n; i++)
            {
                combination[index] = i + 1;
                FindCombinations(n, k, i, index + 1);
            }
        }
    }
}

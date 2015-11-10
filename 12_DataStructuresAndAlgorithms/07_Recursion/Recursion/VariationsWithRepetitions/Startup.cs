namespace VariationsWithRepetitions
{
    using System;

    public class Startup
    {
        private static string[] set = { "hi", "a", "b" };
        private static string[] variation;

        public static void Main()
        {
            int n = set.Length;

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            variation = new string[k];

            FindVariations(n, k, 0);
        }

        private static void FindVariations(int n, int k, int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", variation));

                return;
            }

            for (int i = 0; i < n; i++)
            {
                variation[index] = set[i];
                FindVariations(n, k, index + 1);
            }
        }
    }
}

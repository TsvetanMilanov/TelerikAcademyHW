namespace Permutations
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int[] permutation;

        public static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            permutation = Enumerable.Range(1, n).ToArray();

            FindPermutations(n, 0);
        }

        private static void FindPermutations(int n, int index)
        {
            if (index >= n)
            {
                Console.WriteLine(string.Join(" ", permutation));

                return;
            }

            FindPermutations(n, index + 1);
            for (int i = index + 1; i < n; i++)
            {
                Swap(ref permutation[index], ref permutation[i]);
                FindPermutations(n, index + 1);
                Swap(ref permutation[index], ref permutation[i]);
            }
        }

        private static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}

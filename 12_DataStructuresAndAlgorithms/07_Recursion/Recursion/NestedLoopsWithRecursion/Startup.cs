namespace NestedLoopsWithRecursion
{
    using System;

    public class Startup
    {
        private static int[] combination;

        public static void Main()
        {
            Console.Write("Enter the number of the nested cycles: ");
            int n = int.Parse(Console.ReadLine());
            combination = new int[n];

            RunCycle(n, 0);
            Console.WriteLine();
        }

        private static void RunCycle(int n, int index)
        {
            if (index >= n)
            {
                Console.WriteLine(string.Join(" ", combination));

                return;
            }

            for (int i = 1; i <= n; i++)
            {
                combination[index] = i;
                RunCycle(n, index + 1);
            }
        }
    }
}

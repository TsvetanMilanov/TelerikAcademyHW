namespace CalculateQueueSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int n = 2;
            var sums = new Queue<int>();
            sums.Enqueue(n);

            for (int i = 1; i <= 50; i++)
            {
                int previousSum = sums.Peek();
                sums.Enqueue(previousSum + 1);
                sums.Enqueue(2 * previousSum + 1);
                sums.Enqueue(previousSum + 2);

                Console.Write("{0} ", sums.Dequeue());
            }

            Console.WriteLine();
        }
    }
}

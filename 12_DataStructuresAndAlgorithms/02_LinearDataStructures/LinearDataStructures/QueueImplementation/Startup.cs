namespace QueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedQueue<int> customQueue = new LinkedQueue<int>();

            for (int i = 0; i < 50; i++)
            {
                customQueue.Enqueue(i);
            }

            Console.WriteLine("Items in the custom queue:");
            while (customQueue.Head != null)
            {
                Console.Write("{0} ", customQueue.Dequeue());
            }

            Console.WriteLine();
        }
    }
}

namespace PriorityQueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(15);
            priorityQueue.Enqueue(6);

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}

namespace ReverseIntegerSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter the sequence size: ");
            int numbersCount = int.Parse(Console.ReadLine());

            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Enter number: ");
                int currentNumber = int.Parse(Console.ReadLine());

                sequence.Push(currentNumber);
            }

            var reversedSequence = new List<int>();

            while (sequence.Count > 0)
            {
                int lastElement = sequence.Pop();

                reversedSequence.Add(lastElement);
            }

            Console.WriteLine("The reversed sequence is: {0}", string.Join(", ", reversedSequence));
        }
    }
}

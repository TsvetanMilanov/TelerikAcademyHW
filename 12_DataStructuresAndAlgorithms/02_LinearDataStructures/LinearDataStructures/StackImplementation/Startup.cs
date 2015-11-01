namespace StackImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var stack = new CustomStack<int>();

            for (int i = 0; i < 50; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("The items in the stack are:");
            int stackCount = stack.Count;
            for (int i = 0; i < stackCount; i++)
            {
                Console.Write("{0} ", stack.Pop());
            }

            Console.WriteLine();
        }
    }
}

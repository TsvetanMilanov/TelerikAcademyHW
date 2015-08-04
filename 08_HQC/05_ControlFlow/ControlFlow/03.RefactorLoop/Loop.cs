namespace RefactorLoop
{
    using System;

    public class Loop
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < array.length; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }

            // More code here
        }
    }
}

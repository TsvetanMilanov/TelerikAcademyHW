using System;

/*Problem 16.* Print Long Sequence

Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).*/

class PrintLongSequence
{
    static void Main(string[] args)
    {
        int count = 1000, number = 2;

        for (int i = 0; i < count; i++, number++)
        {

            if (number % 2 == 0)
            {
                if (number == (count + 1))
                {
                    Console.Write(number + "\n");
                }
                else
                {
                    Console.Write(number + ", ");
                }
            }
            else
            {
                if (number == (count + 1))
                {
                    Console.Write(-number + "\n");
                }
                else
                {
                    Console.Write(-number + ", ");
                }
            }
        }
    }
}

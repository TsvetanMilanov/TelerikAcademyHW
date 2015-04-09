using System;

/*Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

class PrintSequence
{
    static void Main(string[] args)
    {
        int n = 12;
        for (int number = 2; number < n; number++)
        {
            if (number % 2 == 0)
            {
                if (number == (n - 1))
                {
                    Console.Write(number + "\n");
                }
                else
                {
                    Console.Write(number + ", ");
                }
            }
            if (number % 2 != 0)
            {
                if (number == (n - 1))
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

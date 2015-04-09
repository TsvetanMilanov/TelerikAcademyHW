using System;

/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
 */

class SortThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("c:");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else if (b <= c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            else if (a <= c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
        }
        else if (c >= a && c >= b)
        {
            if (a >= b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            else if (a <= b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
        }
    }
}

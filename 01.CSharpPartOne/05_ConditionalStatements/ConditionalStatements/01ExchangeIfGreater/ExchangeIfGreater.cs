using System;

/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 * */

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = double.Parse(Console.ReadLine());
        double temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}

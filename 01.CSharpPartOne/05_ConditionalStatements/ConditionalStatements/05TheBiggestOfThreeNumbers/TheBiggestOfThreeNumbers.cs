using System;

/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */

class TheBiggestOfThreeNumbers
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
            Console.WriteLine("The biggest number is a = {0}", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The biggest number is b = {0}", b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine("The biggest number is c = {0}", c);
        }
    }
}

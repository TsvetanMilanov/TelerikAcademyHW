using System;

/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */

class RandomNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter min value:");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter max value:");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();

        int number;
        if (min > max || min == max)
        {
            Console.WriteLine("Incorrect input data.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            number = random.Next(min, max + 1);
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
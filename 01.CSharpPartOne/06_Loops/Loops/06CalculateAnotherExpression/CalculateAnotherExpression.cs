using System;

/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
 */

class CalculateAnotherExpression
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for k:");
        int k = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        int kFactorial = 1;

        if (k <= 1 || k > n || n >= 100)
        {
            Console.WriteLine("Invalid input data.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;

            if(i > k)
            {
                continue;
            }

            kFactorial *= i;
        }

        decimal result = nFactorial/kFactorial;

        Console.WriteLine("The result is: {0}", result);

    }
}

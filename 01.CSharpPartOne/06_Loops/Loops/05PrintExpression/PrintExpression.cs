using System;

/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
 */

class PrintExpression
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for x:");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1m;
        int nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            sum += (decimal)nFactorial / (decimal)Math.Pow(x, i);
        }

        Console.WriteLine("The sum is : {0:0.00000}", sum);
    }
}
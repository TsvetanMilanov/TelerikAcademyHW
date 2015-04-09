using System;
using System.Numerics;

/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
 */

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 100)
        {
            Console.WriteLine("Incorect input data.");
            return;
        }

        int secondNumber = 2 * n;
        int thirdNumber = n + 1;

        BigInteger nFactorial = 1;
        BigInteger secondFactorial = 1;
        BigInteger thirdFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= (BigInteger)i;
        }

        for (int j = 1; j <= secondNumber; j++)
        {
            secondFactorial *= (BigInteger)j;
        }

        for (int k = 1; k <= thirdNumber; k++)
        {
            thirdFactorial *= (BigInteger)k;
        }

        double result = (double)secondFactorial / (double)(thirdFactorial * nFactorial);
        Console.WriteLine("The result is: {0}", result);
    }
}

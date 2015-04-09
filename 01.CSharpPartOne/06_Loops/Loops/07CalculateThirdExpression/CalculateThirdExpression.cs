using System;
using System.Numerics;

/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements
(also known as the number of combinations) is calculated by the following formula: formula.
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/
class CalculateThirdExpression
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for k:");
        int k = int.Parse(Console.ReadLine());

        int thirdNumber = n - k;

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;

        if (k <= 1 || k > n || n >= 100)
        {
            Console.WriteLine("Invalid input data.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= (BigInteger)i;

            if (i > k)
            {
                continue;
            }

            kFactorial *= (BigInteger)i;
        }

        for (int j = 1; j <= thirdNumber; j++)
        {
            nMinusKFactorial *= (BigInteger)j;
        }

        double result = (double)nFactorial / (double)(kFactorial * nMinusKFactorial);
        Console.WriteLine("The result is: {0}", result);
    }
}

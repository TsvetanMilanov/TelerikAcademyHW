using System;
using System.Numerics;
using System.Linq;

/*Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
 */

class TralingZeroesInFactorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nFor bigger numbers the factorial will bi bigger and will take long time to calculate!\n");

        BigInteger nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }

        string numberString = nFactorial.ToString();

        numberString = new string(numberString.Reverse().ToArray());

        int currentNumber = numberString[0];

        int zeroesCount = 0;

        int index = 1;

        while (currentNumber == 48)
        {
            zeroesCount++;
            currentNumber = numberString[index];
            index++;
        }

        Console.WriteLine("The count of trailing zeroes is: {0}", zeroesCount);
    }
}

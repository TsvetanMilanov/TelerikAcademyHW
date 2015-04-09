using System;
using System.Collections.Generic;
using System.Linq;

/*Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
 */

class GCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of b:");
        int b = int.Parse(Console.ReadLine());

        int gcd = 0;

        int number = a;
        int q;
        int r;
        int secondNumber = b;

        if (b == 0)
        {
            gcd = a;
            Console.WriteLine("The GCD(a, b) is: {0}", gcd);
            return;
        }

        do
        {
            q = number / secondNumber;

            r = number - q * secondNumber;

            number = secondNumber;

            secondNumber = r;

            if (r != 0)
            {
                gcd = r;
            }
        } while (r != 0);

        Console.WriteLine("The GCD(a, b) is: {0}", gcd);
    }
}
using System;

/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 * */
class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        decimal sum = 0m;
        decimal number = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number #{0}: ", i);
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}

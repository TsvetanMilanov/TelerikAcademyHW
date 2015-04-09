using System;

/*Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the numbers: ");

        string numbers = Console.ReadLine();

        string[] separateNumbers = numbers.Split(' ');

        decimal sum = 0;

        for (int i = 0; i < separateNumbers.Length; i++)
        {
            sum += Convert.ToDecimal(separateNumbers[i]);
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}

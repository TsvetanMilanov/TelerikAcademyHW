using System;
/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/

class SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        decimal sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("\nThe sum of {0}, {1} and {2} is: {3: 0.0}\n", firstNumber, secondNumber, thirdNumber, sum);
    }
}

using System;

/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/

class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        bool isOdd = false;

        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 || number == 0)
        {
            isOdd = false;
        }
        else
        {
            isOdd = true;
        }

        if (isOdd == true)
        {
            Console.WriteLine("The number {0} is Odd. (true)", number);
        }
        else
        {
            Console.WriteLine("The number {0} is Even. (false)", number);
        }
    }
}
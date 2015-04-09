using System;

/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers:");
        string numbers = Console.ReadLine();

        string[] number;

        number = numbers.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < number.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= int.Parse(number[i]);
            }
            else
            {
                oddProduct *= int.Parse(number[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
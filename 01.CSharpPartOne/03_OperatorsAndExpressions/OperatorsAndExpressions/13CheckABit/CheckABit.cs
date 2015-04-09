using System;

/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
in given integer number n, has value of 1.*/


class CheckABit
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1;

        number = number >> position;

        int result = number & mask;

        bool resultBool = false;
        if (result != 0)
        {
            resultBool = true;
        }

        Console.WriteLine(resultBool);
    }
}

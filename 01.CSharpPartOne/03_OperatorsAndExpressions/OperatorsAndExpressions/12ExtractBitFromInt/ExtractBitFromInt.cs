using System;

/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/

class ExtractBitFromInt
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1;
        int numberInPosition = 0;

        number = number >> position;

        int result = number & mask;

        if (result != 0)
        {
            numberInPosition = 1;
        }

        Console.WriteLine("The bit in position {0} is: {1}", position, numberInPosition);
    }
}

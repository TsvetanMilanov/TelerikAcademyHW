using System;

/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

class BitwiseExtractBit
{
    static void Main(string[] args)
    {

        Console.Write("Enter the number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 8;
        uint result = number & mask;
        int thirdBit = 0;

        if (result != 0)
        {
            thirdBit = 1;
        }
        Console.WriteLine("The third bit is: {0}", thirdBit);
    }
}

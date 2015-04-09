using System;

/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

class BitExchange
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        uint number = uint.Parse(Console.ReadLine());

        int firstMask = (int)Math.Pow(2, 3);
        int secondMask = (int)Math.Pow(2, 4);
        int thirdMask = (int)Math.Pow(2, 5);

        int fourthMask = (int)Math.Pow(2, 24);
        int fifthMask = (int)Math.Pow(2, 25);
        int sixthMask = (int)Math.Pow(2, 26);

        int firstBit = 0;
        int secondBit = 0;
        int thirdBit = 0;
        int fourthBit = 0;
        int fifthBit = 0;
        int sixthBit = 0;

        uint result = 0;

        uint TempNumber = number >> 3;

        result = TempNumber & 1;

        if (result != 0)
        {
            firstBit = 1;
        }

        TempNumber = number >> 4;

        result = TempNumber & 1;

        if (result != 0)
        {
            secondBit = 1;
        }

        TempNumber = number >> 5;

        result = TempNumber & 1;

        if (result != 0)
        {
            thirdBit = 1;
        }

        TempNumber = number >> 24;

        result = TempNumber & 1;

        if (result != 0)
        {
            fourthBit = 1;
        }

        TempNumber = number >> 25;

        result = TempNumber & 1;

        if (result != 0)
        {
            fifthBit = 1;
        }

        TempNumber = number >> 26;

        result = TempNumber & 1;

        if (result != 0)
        {
            sixthBit = 1;
        }

        if (fourthBit == 1 && firstBit == 0)
        {
            number = number | (uint)firstMask;
        }
        else if (fourthBit == 0 && firstBit == 1)
        {
            number = number ^ (uint)firstMask;
        }

        if (fifthBit == 1 && secondBit == 0)
        {
            number = number | (uint)secondMask;
        }
        else if (fifthBit == 0 && secondBit == 1)
        {
            number = number ^ (uint)secondMask;
        }

        if (sixthBit == 1 && thirdBit == 0)
        {
            number = number | (uint)thirdMask;
        }
        else if (sixthBit == 0 && thirdBit == 1)
        {
            number = number ^ (uint)thirdMask;
        }

        if (fourthBit == 1 && firstBit == 0)
        {
            number = number ^ (uint)fourthMask;
        }
        else if (fourthBit == 0 && firstBit == 1)
        {
            number = number | (uint)fourthMask;
        }

        if (fifthBit == 1 && secondBit == 0)
        {
            number = number ^ (uint)fifthMask;
        }
        else if (fifthBit == 0 && secondBit == 1)
        {
            number = number | (uint)fifthMask;
        }

        if (sixthBit == 1 && thirdBit == 0)
        {
            number = number ^ (uint)sixthMask;
        }
        else if (sixthBit == 0 && thirdBit == 1)
        {
            number = number | (uint)sixthMask;
        }

        string binaryString = Convert.ToString(number, 2);
        Console.WriteLine("\n" + binaryString + "\t" + number + "\n");
    }
}

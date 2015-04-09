using System;

/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short,
ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

class DeclareVariables
{
    static void Main(string[] args)
    {
        byte firstVariable = 97;
        sbyte secondVariable = -115;
        ushort thirdVariable = 52130;
        short fourthVariable = -10000;
        int fifthVariable = 4825932;

        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
        Console.WriteLine(thirdVariable);
        Console.WriteLine(fourthVariable);
        Console.WriteLine(fifthVariable);
    }
}


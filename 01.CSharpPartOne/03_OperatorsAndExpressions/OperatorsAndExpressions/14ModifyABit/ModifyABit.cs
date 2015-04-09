using System;

/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v
at the position p from the binary representation of n while preserving all other bits in n.*/

class ModifyABit
{
    static void Main(string[] args)
    {

        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter the changed value: ");
        int changeNumber = int.Parse(Console.ReadLine());

        int numberInPosition = 0;
        int mask = (int)Math.Pow(2, position);

        int tempNumber = number >> position;

        int result = tempNumber & 1;
        if (result != 0)
        {
            numberInPosition = 1;
        }
        else
        {
            numberInPosition = 0;
        }

        if ((changeNumber == 1 && numberInPosition == 0))
        {
            number = number | mask;
        }
        else if ((changeNumber == 0 && numberInPosition == 1))
        {
            number = number ^ mask;
        }

        string bitString = Convert.ToString(number, 2);
        Console.WriteLine("The binary number after the change is: {0}", bitString);
        Console.WriteLine("The decimal number after the change is: {0}", number);
    }
}

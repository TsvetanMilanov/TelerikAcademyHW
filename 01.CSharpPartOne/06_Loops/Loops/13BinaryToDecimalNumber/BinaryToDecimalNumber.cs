using System;
using System.Linq;

/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the binary number:");
        string number = Console.ReadLine();

        string numberInReverseOrder = new string(number.Reverse().ToArray());

        long decimalNumber = 0L;

        for (int i = 0; i < numberInReverseOrder.Length; i++)
        {
            if (numberInReverseOrder[i] == '1')
            {
                decimalNumber += (long)Math.Pow(2.0, (double)i);
            }
        }
        Console.WriteLine(decimalNumber);
    }
}

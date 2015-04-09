using System;
using System.Linq;
using System.Collections.Generic;

/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the decimal number:");
        long number = long.Parse(Console.ReadLine());

        List<string> result = new List<string>();

        do
        {
            if (number % 2 == 0)
            {
                result.Add("0");
            }
            else
            {
                result.Add("1");
            }
            number /= 2;
        } while (number != 0);

        //Make string from list
        string resultString = string.Join("", result);

        //Reverse the string
        resultString = new string(resultString.Reverse().ToArray());

        Console.WriteLine(resultString);
    }
}

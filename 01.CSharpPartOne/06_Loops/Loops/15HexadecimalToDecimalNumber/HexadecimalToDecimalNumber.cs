using System;
using System.Collections.Generic;
using System.Linq;

/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the hexadecimal number:");
        string number = Console.ReadLine();

        string numberInReverseOrder = new string(number.Reverse().ToArray());

        long decimalNumber = 0L;

        for (int i = 0; i < numberInReverseOrder.Length; i++)
        {
            switch (numberInReverseOrder[i])
            {
                case '1':
                    decimalNumber += (long)(1 * Math.Pow(16, i));
                    break;
                case '2':
                    decimalNumber += (long)(2 * Math.Pow(16, i));
                    break;
                case '3':
                    decimalNumber += (long)(3 * Math.Pow(16, i));
                    break;
                case '4':
                    decimalNumber += (long)(4 * Math.Pow(16, i));
                    break;
                case '5':
                    decimalNumber += (long)(5 * Math.Pow(16, i));
                    break;
                case '6':
                    decimalNumber += (long)(6 * Math.Pow(16, i));
                    break;
                case '7':
                    decimalNumber += (long)(7 * Math.Pow(16, i));
                    break;
                case '8':
                    decimalNumber += (long)(8 * Math.Pow(16, i));
                    break;
                case '9':
                    decimalNumber += (long)(9 * Math.Pow(16, i));
                    break;
                case 'A':
                    decimalNumber += (long)(10 * Math.Pow(16, i));
                    break;
                case 'B':
                    decimalNumber += (long)(11 * Math.Pow(16, i));
                    break;
                case 'C':
                    decimalNumber += (long)(12 * Math.Pow(16, i));
                    break;
                case 'D':
                    decimalNumber += (long)(13 * Math.Pow(16, i));
                    break;
                case 'E':
                    decimalNumber += (long)(14 * Math.Pow(16, i));
                    break;
                case 'F':
                    decimalNumber += (long)(15 * Math.Pow(16, i));
                    break;
                default:
                    decimalNumber += 0;
                    break;
            }
        }
        Console.WriteLine(decimalNumber);
    }
}

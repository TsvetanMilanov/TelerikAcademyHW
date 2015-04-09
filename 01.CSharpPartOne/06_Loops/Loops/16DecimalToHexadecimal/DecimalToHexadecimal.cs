using System;
using System.Collections.Generic;
using System.Linq;

/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the decimal number:");
        long number = long.Parse(Console.ReadLine());

        List<string> result = new List<string>();

        do
        {
            switch (number % 16)
            {
                case 0:
                    result.Add("0");
                    break;
                case 1:
                    result.Add("1");
                    break;
                case 2:
                    result.Add("2");
                    break;
                case 3:
                    result.Add("3");
                    break;
                case 4:
                    result.Add("4");
                    break;
                case 5:
                    result.Add("5");
                    break;
                case 6:
                    result.Add("6");
                    break;
                case 7:
                    result.Add("7");
                    break;
                case 8:
                    result.Add("8");
                    break;
                case 9:
                    result.Add("9");
                    break;
                case 10:
                    result.Add("A");
                    break;
                case 11:
                    result.Add("B");
                    break;
                case 12:
                    result.Add("C");
                    break;
                case 13:
                    result.Add("D");
                    break;
                case 14:
                    result.Add("E");
                    break;
                case 15:
                    result.Add("F");
                    break;
                default:
                    Console.WriteLine("Something went wrong when dividing by 16.");
                    break;
            }
            number /= 16;
        } while (number != 0);

        //Make string from list
        string resultString = string.Join("", result);

        //Reverse the string
        resultString = new string(resultString.Reverse().ToArray());

        Console.WriteLine(resultString);
    }
}
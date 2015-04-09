using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
 */

namespace _11FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal: {0:D15}", number);
            Console.WriteLine("Hexadecimal: {0:X15}", number);
            Console.WriteLine("Percentage: {0:P15}", number);
            Console.WriteLine("Scientific notation: {0:E15}", number);
        }
    }
}

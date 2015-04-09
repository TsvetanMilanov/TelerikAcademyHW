using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

namespace _03DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());

            string hexadecimalSymbols = "0123456789ABCDEF";

            int temp = number;
            string result = "";

            while (temp != 0)
            {
                result += hexadecimalSymbols[temp % 16];

                temp /= 16;
            }

            string hexResult = "";

            for (int i = 0, j = result.Length - 1; i < result.Length; i++, j--)
            {
                hexResult += result[j];
            }
            Console.WriteLine(hexResult);
        }
    }
}

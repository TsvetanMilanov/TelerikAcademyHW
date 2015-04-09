using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

namespace _06BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the binary number: ");
            string input = Console.ReadLine();

            int neededLength = input.Length;

            while (neededLength % 4 != 0)
            {
                neededLength += input.Length % 4;
            }

            input = input.PadLeft(neededLength, '0');

            string result = "";
            string hexadecimalSymbols = "0123456789ABCDEF";
            string[] binarySymbols = InitBinarySymbols();

            string subString = input.Substring(0, 4);

            int startIndex = 0;
            while (startIndex < input.Length)
            {
                subString = input.Substring(startIndex, 4);

                int index = Array.IndexOf(binarySymbols, subString);

                result += hexadecimalSymbols[index];

                startIndex += 4;
            }

            Console.WriteLine(result);

        }

        private static string[] InitBinarySymbols()
        {
            string[] result = new string[16];

            for (int i = 0; i < 16; i++)
            {
                result[i] = Convert.ToString(i, 2).PadLeft(4, '0');
            }

            return result;
        }
    }
}

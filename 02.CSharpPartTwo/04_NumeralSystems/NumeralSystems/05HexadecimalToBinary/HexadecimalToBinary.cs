using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

namespace _05HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hexadecimal number: ");
            string input = Console.ReadLine();
            string number = input.ToUpper();

            string[] binarySymbols = InitBinarySymbols();
            string hexadecimalSymbols = "0123456789ABCDEF";
            string result = "";

            int index = 0;

            foreach (var digit in number)
            {
                index = hexadecimalSymbols.IndexOf(digit);
                result += binarySymbols[index];
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

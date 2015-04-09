using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */

namespace _01DecimalToBinary
{
    class DecimalToBonary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            string result = "";

            while (temp != 0)
            {
                if (temp % 2 == 1)
                {
                    result += '1';
                }
                else
                {
                    result += '0';
                }

                temp /= 2;
            }

            string binaryResult = "";

            for (int i = 0, j = result.Length - 1; i < result.Length; i++, j--)
            {
                binaryResult += result[j];
            }
            Console.WriteLine(binaryResult);
        }
    }
}

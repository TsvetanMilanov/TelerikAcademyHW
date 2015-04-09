using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
 */

namespace _04HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();

            int result = 0;
            int numberToAdd = 0;
            int currentNumber = 0;
            int currentPow = 0;

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                currentNumber = Convert.ToInt32(number[i]);
                if (currentNumber >= 48 && currentNumber <= 57)
                {
                    currentNumber -= 48;
                }
                if ((currentNumber >= 65 && currentNumber <= 70))
                {
                    currentNumber -= 55;
                }
                if ((currentNumber >= 97 && currentNumber <= 102))
                {
                    currentNumber -= 87;
                }

                currentPow = (int)Math.Pow(16, j);

                numberToAdd = currentNumber * currentPow;

                result += numberToAdd;
            }

            Console.WriteLine(result);
        }
    }
}

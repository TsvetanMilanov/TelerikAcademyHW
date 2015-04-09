using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

namespace _02BinaryToDecimal
{
    class BinaryToDecimal
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
                currentNumber = Convert.ToInt32(number[i]) - 48;
                currentPow = (int)Math.Pow(2, j);

                numberToAdd = currentNumber * currentPow;

                result += numberToAdd;
            }

            Console.WriteLine(result);
        }
    }
}

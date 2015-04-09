using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
 */

namespace _07ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseTheNumber(number);

            Console.WriteLine("The reversed number is: {0}", reversedNumber);
        }

        private static int ReverseTheNumber(int number)
        {
            int reversedNumber = 0;
            int tempNumber = number;
            int currentDigit = 0;

            string digitAsString = "";

            while (tempNumber != 0)
            {
                currentDigit = tempNumber % 10;

                digitAsString += currentDigit;

                tempNumber /= 10;
            }

            reversedNumber = int.Parse(digitAsString);

            return reversedNumber;
        }
    }
}

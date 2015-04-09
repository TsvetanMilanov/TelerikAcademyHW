using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
 */

namespace _03EnglishDigit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            PrintLastDigit(number);
        }

        private static void PrintLastDigit(int number)
        {
            int lastDigit = number % 10;
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine(digits[lastDigit]);
        }
    }
}

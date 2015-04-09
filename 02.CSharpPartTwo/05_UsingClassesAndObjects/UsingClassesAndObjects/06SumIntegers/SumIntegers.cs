using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
 */

namespace _06SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            //For console input:
            //Console.WriteLine("Enter the numbers separated by space:");
            //string inputNumbers = Console.ReadLine();

            string inputNumbers = "43 68 9 23 318";

            FindSum(inputNumbers);
        }

        private static void FindSum(string inputNumbers)
        {
            int sum = 0;

            var allNumbersAsString = inputNumbers.Split(' ');
            int[] allNumbers = Array.ConvertAll<string, int>(allNumbersAsString, int.Parse);

            foreach (var number in allNumbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}

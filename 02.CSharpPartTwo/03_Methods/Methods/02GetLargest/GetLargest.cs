using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

namespace _02GetLargest
{
    class GetLargest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber, thirdNumber);

        }

        private static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber >= Math.Max(secondNumber, thirdNumber))
            {
                Console.WriteLine("The largest number is: {0}", firstNumber);
            }
            else if (secondNumber >= Math.Max(firstNumber, thirdNumber))
            {
                Console.WriteLine("The largest number is: {0}", secondNumber);
            }
            else if (thirdNumber >= Math.Max(firstNumber, secondNumber))
            {
                Console.WriteLine("The largest number is: {0}", thirdNumber);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

namespace _01SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            double result = 0;

            try
            {
                Console.WriteLine("Enter the number:");

                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new FormatException();
                }
                result = Math.Sqrt(number);

                Console.WriteLine("The square root of {0} = {1}", number, result);

            }
            catch (Exception exception)
            {
                Console.WriteLine("Invalid number. {0}", exception.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

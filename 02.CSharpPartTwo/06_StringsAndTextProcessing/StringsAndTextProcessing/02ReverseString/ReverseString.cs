using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
 */

namespace _02ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            var stringArray = inputString.ToArray();

            Array.Reverse(stringArray);

            var result = string.Join("", stringArray);

            Console.WriteLine(result);
        }
    }
}

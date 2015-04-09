using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */

namespace _06StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            while (inputString.Length > 20)
            {
                Console.Write("Enter string with length less than 20: ");
                inputString = Console.ReadLine();
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(inputString);

            for (int i = inputString.Length; i < 20; i++)
            {
                stringBuilder.Append("*");
            }

            Console.WriteLine("The result is: {0}", stringBuilder.ToString());
        }
    }
}

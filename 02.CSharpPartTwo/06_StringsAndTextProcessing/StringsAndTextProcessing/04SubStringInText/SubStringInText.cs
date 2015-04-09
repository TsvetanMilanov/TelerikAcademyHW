using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
 */

namespace _04SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            //For concole input:
            //Console.Write("Enter the string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the substring: ");
            //string subString = Console.ReadLine();

            string inputString = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string subString = "in";

            int index = 0;

            int appearanceCount = 0;

            string inputStringToLower = inputString.ToLower();
            string subStringToLower = subString.ToLower();

            string currentString = inputStringToLower.Substring(0);

            while (true)
            {
                if (currentString.Contains(subStringToLower))
                {
                    index = currentString.IndexOf(subStringToLower);
                    currentString = currentString.Substring(index + 1);
                    appearanceCount++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("The result is: {0}", appearanceCount);
        }
    }
}

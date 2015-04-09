using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
 */

namespace _05ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            //For concole input:
            //Console.Write("Enter the string: ");
            //string inputString = Console.ReadLine();

            string inputString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string[] tags = { "<upcase>", "</upcase>" };

            string[] splittedInputString = inputString.Split(tags, StringSplitOptions.None);

            string subString = string.Empty;

            for (int i = 1; i < splittedInputString.GetLength(0); i += 2)
            {
                subString = splittedInputString[i].ToUpper();

                splittedInputString[i] = subString;
            }

            Console.WriteLine(string.Join("", splittedInputString));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
 */

namespace _09ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string inputString = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            string result = (string)inputString.Clone();

            for (int i = 0; i < forbiddenWords.GetLength(0); i++)
            {
                result = result.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }

            Console.WriteLine(result);
        }
    }
}

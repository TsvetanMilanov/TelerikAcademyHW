using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */

namespace _23SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string inputString = "aaaaabbbbbcdddeeeedssaa";

            List<char> result = new List<char>();

            bool hasNewLetter = false;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (hasNewLetter)
                {
                    if (i + 1 == inputString.Length)
                    {
                        continue;
                    }
                    if (inputString[i] != inputString[i + 1])
                    {
                        hasNewLetter = false;
                    }
                }
                else
                {
                    result.Add(inputString[i]);
                    if (i + 1 == inputString.Length)
                    {
                        continue;
                    }
                    if (inputString[i] != inputString[i + 1])
                    {
                        hasNewLetter = false;
                    }
                    else
                    {
                        hasNewLetter = true;
                    }
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}

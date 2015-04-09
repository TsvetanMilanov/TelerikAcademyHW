using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
 */

namespace _10UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            //For console input:
            //string inputString = Console.ReadLine();

            string inputString = "Hi!";

            string template = "\\u{0:X4}";

            string result = string.Empty;

            foreach (int symbol in inputString)
            {
                result += string.Format(template, symbol);
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

namespace _15ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            string firstReplaceString = "[URL=";
            string firstStringToReplace ="<a href=\"";

            string replaceBracket = "]";
            string bracketToReplace = "\">";

            string secondReplaceString = "[/URL]";
            string secondtringToReplace ="</a>";

            string result = input.Replace(firstStringToReplace, firstReplaceString);
            result = result.Replace(bracketToReplace, replaceBracket);
            result = result.Replace(secondtringToReplace, secondReplaceString);

            Console.WriteLine(result);
        }
    }
}

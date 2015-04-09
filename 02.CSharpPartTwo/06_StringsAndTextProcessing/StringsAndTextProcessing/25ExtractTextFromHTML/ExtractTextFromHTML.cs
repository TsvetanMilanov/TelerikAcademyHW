using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 */

namespace _25ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            string inputString = "<html>\n<head><title>News</title></head>\n  <body><p><a href=\"http://academy.telerik.com\">Telerik\n    Academy</a>aims to provide free real-world practical\n    training for young people who want to turn into\n    skilful .NET software engineers.</p></body>\n</html>";

            Console.WriteLine(inputString);

            string title = ExtractTitle(inputString);

            string[] paragraphSeparators = { "<p>", "</p>" };

            string[] splittedString = inputString.Split(paragraphSeparators, StringSplitOptions.RemoveEmptyEntries);

            List<string> paragraphs = new List<string>();

            for (int i = 0; i < splittedString.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    paragraphs.Add(splittedString[i]);
                }
            }

            List<string> textAsList = new List<string>();

            List<string> text = new List<string>();

            string currentTextToParse = string.Empty;

            char[] tagSeparators = { '<', '>' };

            for (int i = 0; i < paragraphs.Count; i++)
            {
                currentTextToParse = paragraphs[i];

                string[] splittedText = currentTextToParse.Split(tagSeparators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < splittedText.GetLength(0); j++)
                {
                    if (j % 2 != 0)
                    {
                        textAsList.Add(splittedText[j]);
                    }
                }
                text.Add(string.Join(" ", textAsList));
            }


            Console.WriteLine("\nTitle: {0}", title);

            Console.Write("Text: ");
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

        }

        private static string ExtractTitle(string inputString)
        {
            StringBuilder result = new StringBuilder();

            string tagStart = "title";

            string tagEnd = "/title";

            string subString = string.Empty;

            int startIndex = FindTag(inputString, tagStart) + tagStart.Length;

            int endIndex = FindTag(inputString, tagEnd) - 2;

            for (int i = startIndex; i < endIndex; i++)
            {
                result.Append(inputString[i]);
            }
            return result.ToString();
        }

        static int FindTag(string inputString, string tag)
        {
            int index = 0;

            string subString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i < inputString.Length - tag.Length)
                {
                    subString = inputString.Substring(i, tag.Length);
                    if (subString == tag)
                    {
                        index = i + 1;
                        break;
                    }
                }
                else
                {
                    return -1;
                }
            }
            return index;
        }
    }
}

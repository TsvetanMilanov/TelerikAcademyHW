using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
 */

namespace _08ReplaceWholeWords
{
    class ReplaceWholeWords
    {
        static void Main(string[] args)
        {
            string toBeReplaced = "start";
            string replaceString = "finish";

            string[] inputFromFile = File.ReadAllLines("input.txt");

            string currentLine = string.Empty;

            Console.WriteLine("Replacing words...");
            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {
                char[] wordSeparators = {' ', '.', ',', '/', '?', ';', ':', '\\', '|', '\'', '\"', '1', '!', '2', '@', '3', '#', '4', '$', '5', '%', '6', '^', '7', '&', '8', '*', '9', '(', '0', ')', '-', '_', '=', '+', '[', ']', '{', '}' };

                for (int i = 0; i < inputFromFile.GetLength(0); i++)
                {
                    currentLine = inputFromFile[i];

                    string[] resultLine = currentLine.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < resultLine.GetLength(0); j++)
                    {
                        if (resultLine[j] == toBeReplaced)
                        {
                            resultLine[j] = replaceString;
                        }
                    }

                    streamWriter.WriteLine(string.Join(" ", resultLine));
                }
            }
            Console.WriteLine("Done!");
        }
    }
}

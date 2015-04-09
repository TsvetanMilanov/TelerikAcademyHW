using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
 */

namespace _11PrefixTest
{
    class PrefixTest
    {
        static void Main(string[] args)
        {
            string prefix = "test";

            string[] input = File.ReadAllLines("input.txt");

            string currentLine = string.Empty;

            Console.WriteLine("Removing words...");

            StringBuilder currentWord = new StringBuilder();

            using (StreamWriter streamWriter = new StreamWriter("input.txt"))
            {
                char[] wordSeparators = { ' ', '.', ',', '/', '?', ';', ':', '\\', '|', '\'', '\"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}' };

                for (int i = 0; i < input.GetLength(0); i++)
                {
                    currentLine = input[i];

                    List<string> resultLine = new List<string>(currentLine.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries));

                    for (int j = 0; j < resultLine.Count; j++)
                    {
                        currentWord.Append(resultLine[j]);

                        if (currentWord.ToString().StartsWith(prefix))
                        {
                            resultLine.RemoveAt(j);
                        }
                        currentWord.Clear();
                    }

                    streamWriter.WriteLine(string.Join(" ", resultLine));
                }
            }

            Console.WriteLine("Done!");
        }
    }
}

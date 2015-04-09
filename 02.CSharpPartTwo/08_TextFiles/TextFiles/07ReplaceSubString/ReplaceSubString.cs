using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
 */

namespace _07ReplaceSubString
{
    class ReplaceSubString
    {
        static void Main(string[] args)
        {
            string[] inputFromFile = File.ReadAllLines("input.txt");

            string currentLine = string.Empty;
            StringBuilder resultLine = new StringBuilder();

            Console.WriteLine("Replacing words...");
            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < inputFromFile.Count(); i++)
                {
                    currentLine = inputFromFile[i];

                    resultLine.Append(currentLine);

                    resultLine.Replace("start", "finish");

                    streamWriter.WriteLine(resultLine.ToString());

                    resultLine.Clear();
                }
            }
            Console.WriteLine("Done!");
        }
    }
}

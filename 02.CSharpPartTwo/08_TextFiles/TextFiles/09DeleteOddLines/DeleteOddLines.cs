using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */

namespace _09DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {

            List<string> onlyEvenLines = new List<string>();

            Console.WriteLine("Removing odd lines...");
            using (StreamReader streamReader = new StreamReader("input.txt"))
            {

                string currentLine = string.Empty;

                int lineCounter = 1;

                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (lineCounter % 2 == 0)
                    {
                        onlyEvenLines.Add(currentLine);
                    }

                    lineCounter++;
                }
            }

            using (StreamWriter streamWriter = new StreamWriter("input.txt"))
            {
                foreach (var line in onlyEvenLines)
                {
                    streamWriter.WriteLine(line);
                }
            }

            Console.WriteLine("Done!");
        }
    }
}

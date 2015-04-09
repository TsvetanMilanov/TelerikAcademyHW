using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
 */

namespace _03LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing to file...");
            using (var inputFile = new StreamReader("test.txt"))
            {
                string[] result = File.ReadAllLines("test.txt");

                var streamWriter = new StreamWriter("testOutput.txt");

                int lineCount = 0;

                while (lineCount < result.GetLength(0))
                {
                    int lineNumber = lineCount + 1;

                    streamWriter.WriteLine("{0:00} {1}", lineNumber, result[lineCount]);
                    lineCount++;
                }

                streamWriter.Close();
            }
            Console.WriteLine("Done!");
        }
    }
}

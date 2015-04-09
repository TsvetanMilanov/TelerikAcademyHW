using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
 */

namespace _01OddLines
{

    class OddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("OddLines.txt"))
            {

                string currentLine = string.Empty;

                int lineCounter = 1;

                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(currentLine);
                    }

                    lineCounter++;
                }
            }
        }
    }
}

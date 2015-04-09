using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
 */

namespace _04CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            int equalCounter = 0;
            int notEqualCounter = 0;

            using (StreamReader firstFileReader = new StreamReader("FirstFile.txt"), secondFileReader = new StreamReader("SecondFile.txt"))
            {
                while (firstFileReader.Peek() > 0)
                {
                    string lineOfFirstFile = firstFileReader.ReadLine();
                    string lineOfSecondFile = secondFileReader.ReadLine();

                    if (lineOfFirstFile == lineOfSecondFile)
                    {
                        equalCounter++;
                    }
                    else
                    {
                        notEqualCounter++;
                    }
                }
            }

            Console.WriteLine("The number of equal lines: {0}", equalCounter);
            Console.WriteLine("The number of NOT equal lines: {0}", notEqualCounter);
        }
    }
}

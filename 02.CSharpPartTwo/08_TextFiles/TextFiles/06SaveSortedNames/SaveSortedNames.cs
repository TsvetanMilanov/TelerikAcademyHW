using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */

namespace _06SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            string[] inputFileInformation = File.ReadAllLines("input.txt");

            Console.WriteLine("Sorting the names and writing them to file...");

            Array.Sort(inputFileInformation);
            using (StreamWriter writeToFile = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < inputFileInformation.Count(); i++)
                {
                    writeToFile.WriteLine(inputFileInformation[i]);
                }
            }

            Console.WriteLine("Done!");
        }
    }
}

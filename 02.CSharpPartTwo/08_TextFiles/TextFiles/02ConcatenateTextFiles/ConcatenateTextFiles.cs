using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
 */

namespace _02ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing to file...");
            using (StreamReader firstFile = new StreamReader("FirstFile.txt"), secondFile = new StreamReader("SecondFile.txt"))
            {
                StreamWriter outputFile = new StreamWriter("Output.txt");
                var result = new StringBuilder();

                while (result.Append(firstFile.ReadLine()).ToString() != "")
                {
                    result.Append(secondFile.ReadLine()).ToString();

                    outputFile.WriteLine(result);

                    result.Clear();
                }
                outputFile.Close();
            }
            Console.WriteLine("Done!");
        }
    }
}

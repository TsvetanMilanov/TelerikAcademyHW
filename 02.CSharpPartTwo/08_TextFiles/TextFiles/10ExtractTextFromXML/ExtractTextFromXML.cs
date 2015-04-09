using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
 */

namespace _10ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("input.txt"))
            {
                string currentLine = string.Empty;

                StringBuilder text = new StringBuilder();

                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        if (currentLine[i] == '>')
                        {
                            if (i < currentLine.Length - 1)
                            {
                                i++;
                            }

                            while (currentLine[i] != '<' && i < currentLine.Length-1)
                            {
                                text.Append(currentLine[i]);

                                if (i < currentLine.Length - 1)
                                {
                                    i++;
                                }
                            }
                            if (text.ToString() != "")
                            {
                                Console.WriteLine(text);
                                text.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}

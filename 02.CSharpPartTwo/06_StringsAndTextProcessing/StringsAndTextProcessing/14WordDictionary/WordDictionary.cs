using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
 */

namespace _14WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the key: ");

            string key = Console.ReadLine();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary[".NET"] = "platform for applications from Microsoft";

            dictionary["CLR"] = "managed execution environment for .NET";

            dictionary["namespace"] = "hierarchical organization of classes";

            string result = string.Empty;

            try
            {
                result = dictionary[key];
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine("\n{0}", exception.Message);
            }

            Console.WriteLine("\n{0}\n", result);
        }
    }
}

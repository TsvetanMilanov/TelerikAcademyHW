using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

namespace _24OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            string inputString = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";

            char[] separators = { ' ', '!', '.', ',', '(', ')', '[', ']', '{', '}', '#', '$', '%', '@', '?', '\"', '\'', '`', '|', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '<', '>', ':', ';', '*', '&', '^' };

            string[] allWords = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string[] sortedWords = allWords.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join("\n", sortedWords));
        }
    }
}

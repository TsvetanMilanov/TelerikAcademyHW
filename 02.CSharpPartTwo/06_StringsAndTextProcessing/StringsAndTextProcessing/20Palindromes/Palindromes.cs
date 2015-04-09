using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */

namespace _20Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string inputString = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";

            char[] separators = { ' ', '!', '.', ',', '(', ')', '[', ']', '{', '}', '#', '$', '%', '@', '?', '\"', '\'', '`', '|', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '<', '>', ':', ';', '*', '&', '^' };

            string[] words = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<char[]> wordsAsArrays = new List<char[]>();

            foreach (var word in words)
            {
                wordsAsArrays.Add(word.ToArray());
            }

            List<string> finalResult = new List<string>();
            foreach (var array in wordsAsArrays)
            {
                char[] temp = array.Reverse().ToArray();
                if (array.SequenceEqual(temp) && array.GetLength(0) > 1)
                {
                    finalResult.Add(string.Join("", array));
                }
            }

            Console.WriteLine(string.Join("\n", finalResult));
        }
    }
}

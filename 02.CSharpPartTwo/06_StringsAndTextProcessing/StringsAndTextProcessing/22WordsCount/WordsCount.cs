using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */

namespace _22WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            string inputString = "one two two three three three four four four four five five five five five";

            Console.WriteLine(inputString);


            string[] allWords = inputString.Split();

            char[] separators = { ' ', '!', '.', ',', '(', ')', '[', ']', '{', '}', '#', '$', '%', '@', '?', '\"', '\'', '`', '|', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '<', '>', ':', ';', '*', '&', '^' };

            int counter = 0;

            SortedSet<string> letters = new SortedSet<string>();

            foreach (var word in allWords)
            {
                letters.Add(word);
            }

            foreach (var word in letters)
            {
                counter = 0;
                foreach (var item in allWords)
                {
                    if (word == item)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} -> {1} times.", word, counter);
            }
        }
    }
}

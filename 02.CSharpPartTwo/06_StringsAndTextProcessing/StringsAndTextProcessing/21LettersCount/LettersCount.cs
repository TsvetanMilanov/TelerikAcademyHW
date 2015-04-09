using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
 */

namespace _21LettersCount
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            string inputString = "aafa bbfbb cfccfcfc";

            Console.WriteLine(inputString);

            List<char> allLetters = new List<char>();

            foreach (var symbol in inputString)
            {
                if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                {
                    allLetters.Add(symbol);
                }
            }

            int counter = 0;

            SortedSet<char> letters = new SortedSet<char>();

            foreach (var letter in allLetters)
            {
                letters.Add(letter);
            }

            foreach (var letter in letters)
            {
                counter = 0;
                foreach (var symbol in allLetters)
                {
                    if (letter == symbol)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} -> {1} times.", letter, counter);
            }
        }
    }
}

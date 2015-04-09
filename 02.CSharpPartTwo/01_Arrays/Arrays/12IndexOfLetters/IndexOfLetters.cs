using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */

namespace _12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] letters = MakeArrayOfLetters();

            Console.Write("Enter the word:");
            string word = Console.ReadLine();

            char currentLetter;

            for (int i = 0; i < word.Length; i++)
            {
                currentLetter = word[i];

                for (int j = 0; j < letters.Length; j++)
                {
                    if (currentLetter == letters[j])
                    {
                        Console.WriteLine("{0} is at index: {1}", currentLetter, j);
                    }
                }
            }
        }

        static char[] MakeArrayOfLetters()
        {
            //In the letters array the upperscase letters are first and after them are the lowercase letters.

            char[] letters = new char[52];

            for (int i = 0; i < letters.Length; i++)
            {
                if (i <= 25)
                {
                    letters[i] = (char)(i + 65);
                }
                else
                {
                    letters[i] = (char)(i + 71);
                }
            }

            return letters;
        }

    }
}

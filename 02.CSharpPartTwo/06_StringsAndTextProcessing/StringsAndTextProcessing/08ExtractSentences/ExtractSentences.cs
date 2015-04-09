using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
 */

namespace _08ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            //For console input:
            //string inputString = Console.ReadLine();
            //string word = Console.ReadLine();

            string inputString = "The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string word = "in";

            StringBuilder separateWord = new StringBuilder();

            separateWord.Append(word);

            separateWord.Insert(0, ' ');
            separateWord.Append(' ');

            word = separateWord.ToString();

            string[] sentenceSeparators = { ".", "!", "?", ";", ":" };

            string[] sentences = inputString.Split(sentenceSeparators, StringSplitOptions.None);

            List<string> sentencesContainingWord = new List<string>();

            foreach (var sentence in sentences)
            {
                if (sentence.Contains(word))
                {
                    sentencesContainingWord.Add(sentence);
                }
            }

            foreach (var sentence in sentencesContainingWord)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}

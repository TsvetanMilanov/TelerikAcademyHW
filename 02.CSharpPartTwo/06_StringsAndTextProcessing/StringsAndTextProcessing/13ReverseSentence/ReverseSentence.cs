using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
 */

namespace _13ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            //For console input:
            //string sentence = Console.ReadLine();

            string sentence = "C# is not C++, not PHP and not Delphi!";

            //Find what stands at the sentence end.
            string sentenceEnd = sentence[sentence.Length - 1].ToString();

            //Split the string by commas to find the number of the commas ( the strings after the split -1 ).
            string[] sentenceSplittedByCommas = sentence.Split(',');

            
            Stack<int> commasIndexes = new Stack<int>();

            //Push to the stack all the commas indexes.
            foreach (var subSentence in sentenceSplittedByCommas)
            {
                var temp = subSentence.Split(' ');

                commasIndexes.Push(temp.Length - 1);
            }

            //Pop the last one because the last part of the splitted string has no comma at the end of it.
            commasIndexes.Pop();

            //Array with the separators of the sentence.
            char[] separators = { ',', ' ', sentenceEnd[0] };

            //Split and save only the words.
            string[] reversedSentenceWithoutTHeCommas = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Reverse the words order.
            Array.Reverse(reversedSentenceWithoutTHeCommas);

            List<string> reversedSentence = new List<string>();

            int currentIndex = 0;

            //Add the words and add the commas at the indexes.
            foreach (var word in reversedSentenceWithoutTHeCommas)
            {
                reversedSentence.Add(word);
                if (commasIndexes.Contains(currentIndex))
                {
                    reversedSentence.Add(", ");
                }
                else
                {
                    reversedSentence.Add(" ");
                }
                currentIndex++;
            }

            //Remove the last space from the list.
            reversedSentence.RemoveAt(reversedSentence.Count - 1);

            //Add the end of the sentence.
            reversedSentence.Add(sentenceEnd);

            string result = string.Join("", reversedSentence);

            Console.WriteLine(result);

        }
    }
}

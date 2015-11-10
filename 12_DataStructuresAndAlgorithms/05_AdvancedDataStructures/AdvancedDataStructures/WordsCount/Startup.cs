namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Triepocalypse;

    public class Startup
    {
        public static void Main()
        {
            var input = new StreamReader("../../input.txt");

            string currentLine = input.ReadLine();

            Trie<string> words = new Trie<string>();

            Console.WriteLine("Reading the search words...");
            List<string> searchWords = GetSearchWords();

            Console.WriteLine("Reading the BIG text...");
            while (currentLine != null)
            {
                string[] wordsInCurrentRow = GetWordsFromLine(currentLine);

                foreach (var word in wordsInCurrentRow)
                {
                    if (string.IsNullOrWhiteSpace(word))
                    {
                        continue;
                    }

                    if (!words.ContainsKey(word))
                    {
                        words[word] = 1.ToString();
                    }
                    else
                    {
                        int currentValue = int.Parse(words[word]);

                        words[word] = (currentValue + 1).ToString();
                    }
                }

                currentLine = input.ReadLine();
            }

            foreach (var word in words)
            {
                Console.WriteLine(string.Format("{0} -> {1} occurences", word.Key, word.Value));
            }
        }

        private static List<string> GetSearchWords()
        {
            var text = new StreamReader("../../searchWords.txt");
            List<string> result = new List<string>();

            var currentRow = text.ReadLine();

            while (currentRow != null)
            {
                var wordsInRow = GetWordsFromLine(currentRow);

                foreach (var word in wordsInRow)
                {
                    if (string.IsNullOrWhiteSpace(word))
                    {
                        continue;
                    }

                    result.Add(word);
                }

                currentRow = text.ReadLine();
            }

            return result;
        }

        private static string[] GetWordsFromLine(string currentLine)
        {
            var result = new List<string>();

            StringBuilder word = new StringBuilder();

            for (int i = 0; i < currentLine.Length; i++)
            {
                var currentSymbol = currentLine[i];

                if (char.IsLetter(currentSymbol))
                {
                    word.Append(currentSymbol);
                }
                else
                {
                    result.Add(word.ToString());
                    word.Clear();
                }
            }

            return result.ToArray();
        }
    }
}

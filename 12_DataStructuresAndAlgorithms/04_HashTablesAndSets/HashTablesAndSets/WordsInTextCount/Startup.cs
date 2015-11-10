namespace WordsInTextCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var file = File.OpenText(Directory.GetFiles(Directory.GetCurrentDirectory()).FirstOrDefault(n => n.EndsWith("words.txt")));
            string line = file.ReadLine();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            while (line != null)
            {
                string[] words = SplitWords(line);
                foreach (var word in words)
                {
                    if (occurrences.ContainsKey(word))
                    {
                        occurrences[word] += 1;
                    }
                    else
                    {
                        occurrences[word] = 1;
                    }
                }

                line = file.ReadLine();
            }

            occurrences.OrderBy(a => a.Value);

            foreach (var item in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }

        private static string[] SplitWords(string line)
        {
            var result = new List<string>();

            var word = new StringBuilder();
            foreach (var symbol in line)
            {
                if (char.IsLetter(symbol))
                {
                    word.Append(symbol.ToString().ToLower());
                }
                else
                {
                    if (word.Length > 0)
                    {
                        result.Add(word.ToString());
                        word.Clear();
                    }
                }
            }

            return result.ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

/*Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
 */

namespace _13CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            string[] listOfWords = MakeListOfWords();

            string input = MakeInput();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in listOfWords)
            {
                wordsCount[word] = 0;
            }

            string temp = (string)input.Clone();

            int counter = 0;
            for (int i = 0; i < listOfWords.GetLength(0); i++)
            {
                counter = 0;
                while (temp.Contains(listOfWords[i]))
                {
                    int index = temp.IndexOf(listOfWords[i]);
                    counter++;
                    temp = temp.Remove(index, listOfWords[i].Length);
                }

                wordsCount[listOfWords[i]] = counter;
            }

            var sortedResult = from pair in wordsCount orderby pair.Value descending select pair;

            Console.WriteLine("Wtiting result to file...");

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var item in sortedResult)
                {

                    writer.WriteLine("{0} -> {1} times.", item.Key, item.Value);
                }
            }

            Console.WriteLine("Done!");

        }

        private static string[] MakeListOfWords()
        {
            string input = string.Empty;

            try
            {
                input = File.ReadAllText("words.txt");
            }
            catch (ArgumentNullException argumentNullException)
            {
                Console.WriteLine(argumentNullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
            catch (PathTooLongException pathTooLongException)
            {
                Console.WriteLine(pathTooLongException.Message);
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                Console.WriteLine(directoryNotFoundException.Message);
            }
            catch (FileNotFoundException fileNotFoundException)
            {
                Console.WriteLine(fileNotFoundException.Message);
            }
            catch (IOException ioException)
            {
                Console.WriteLine(ioException.Message);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                Console.WriteLine(unauthorizedAccessException.Message);
            }
            catch (NotSupportedException notSupportedException)
            {
                Console.WriteLine(notSupportedException.Message);
            }
            catch (SecurityException securityException)
            {
                Console.WriteLine(securityException.Message);
            }

            char[] wordSeparators = { '\n', '\r', '\t', ' ', '.', ',', '/', '?', ';', ':', '\\', '|', '\'', '\"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}' };
            string[] result = input.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

            return result;
        }

        private static string MakeInput()
        {
            string result = string.Empty;

            try
            {
                result = File.ReadAllText("test.txt");
            }
            catch (ArgumentNullException argumentNullException)
            {
                Console.WriteLine(argumentNullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
            catch (PathTooLongException pathTooLongException)
            {
                Console.WriteLine(pathTooLongException.Message);
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                Console.WriteLine(directoryNotFoundException.Message);
            }
            catch (FileNotFoundException fileNotFoundException)
            {
                Console.WriteLine(fileNotFoundException.Message);
            }
            catch (IOException ioException)
            {
                Console.WriteLine(ioException.Message);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                Console.WriteLine(unauthorizedAccessException.Message);
            }
            catch (NotSupportedException notSupportedException)
            {
                Console.WriteLine(notSupportedException.Message);
            }
            catch (SecurityException securityException)
            {
                Console.WriteLine(securityException.Message);
            }

            return result;
        }
    }
}

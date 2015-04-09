using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

/*Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */

namespace _12RemoveWords
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = MakeListOfWords();

            string input = MakeInput();

            Console.WriteLine("Removing forbidden words from file...");
            RemoveWordsFromFile(forbiddenWords, input);
            Console.WriteLine("Done!");
        }

        private static void RemoveWordsFromFile(string[] forbiddenWords, string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                stringBuilder.Append(input);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Console.WriteLine(argumentOutOfRangeException.Message);
            }

            for (int i = 0; i < forbiddenWords.GetLength(0); i++)
            {
                try
                {
                    stringBuilder.Replace(forbiddenWords[i], "");
                }
                catch (ArgumentOutOfRangeException argumentOutOfRangeException)
                {
                    Console.WriteLine(argumentOutOfRangeException.Message);
                }
                catch (ArgumentNullException argumentNullException)
                {
                    Console.WriteLine(argumentNullException.Message);
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine(argumentException.Message);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter("input.txt"))
            {
                try
                {
                    streamWriter.Write(stringBuilder.ToString());
                }
                catch (ObjectDisposedException objectDisposedException)
                {
                    Console.WriteLine(objectDisposedException.Message);
                }
                catch (NotSupportedException notSupportedException)
                {
                    Console.WriteLine(notSupportedException.Message);
                }
                catch (IOException ioException)
                {
                    Console.WriteLine(ioException.Message);
                }
            }
        }

        private static string MakeInput()
        {
            string result = string.Empty;

            try
            {
                result = File.ReadAllText("input.txt");
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

        private static string[] MakeListOfWords()
        {
            string input = string.Empty;

            try
            {
                input = File.ReadAllText("ForbiddenWords.txt");
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
    }
}

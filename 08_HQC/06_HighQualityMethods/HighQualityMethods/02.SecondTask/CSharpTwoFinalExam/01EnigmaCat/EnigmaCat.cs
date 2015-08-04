namespace Enigma
{
    using System;
    using System.Numerics;
    using System.Text;

    public class EnigmaCat
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputNumbers = input.Split(' ');

            int inputNumbersLength = inputNumbers.GetLength(0);
            BigInteger[] allNumbersInSeventeenBaseSystem = new BigInteger[inputNumbersLength];

            for (int i = 0; i < inputNumbersLength; i++)
            {
                string currentNumber = inputNumbers[i];

                allNumbersInSeventeenBaseSystem[i] = ConvertWordToNumberInSeventeenBaseSystem(currentNumber);
            }

            string[] numbersConvertedToWords = new string[allNumbersInSeventeenBaseSystem.Length];

            for (int i = 0; i < allNumbersInSeventeenBaseSystem.Length; i++)
            {
                int currentNumber = (int)allNumbersInSeventeenBaseSystem[i];
                numbersConvertedToWords[i] = ConvertNumberToWord(currentNumber);
            }

            Console.WriteLine(string.Join(" ", numbersConvertedToWords));
        }

        public static BigInteger ConvertWordToNumberInSeventeenBaseSystem(string word)
        {
            BigInteger number = 0;
            int pow = word.Length - 1;
            string currentWord = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                BigInteger currentLetterCode = currentWord[i] - 'a';
                BigInteger calculatedPow = (BigInteger)Math.Pow(17, pow);

                number += currentLetterCode * calculatedPow;

                pow--;
            }

            return number;
        }

        private static string ConvertNumberToWord(int number)
        {
            StringBuilder word = new StringBuilder();
            string allLetters = "abcdefghijklmnopqrstuvwxyz";

            while (number > 0)
            {
                word.Insert(0, allLetters[number % 26]);
                number /= 26;
            }

            return word.ToString();
        }
    }
}
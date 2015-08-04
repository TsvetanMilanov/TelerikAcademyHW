using System;

class SearchInBits
{
    static void Main(string[] args)
    {
        long numberToGetBitsFrom = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());

        int[] allNumbers = ReadNumbersInputFromConsole(numbersCount);

        string[] binaryNumbers = ConvertNumbersToBinaryStrings(allNumbers);

        string sequenceToSearchFor = CreateStringToSearchFor(numberToGetBitsFrom);
        long occurences = 0;

        for (int i = 0; i < binaryNumbers.Length; i++)
        {
            string currentNumber = binaryNumbers[i];

            for (int j = currentNumber.Length - 1; j >= 3; j--)
            {
                string currentCombination = GetFourSymbolsFromPosition(currentNumber, j);

                if (currentCombination.Equals(sequenceToSearchFor))
                {
                    occurences++;
                }

                currentCombination = String.Empty;
            }
        }

        Console.WriteLine(occurences);
    }

    private static string GetFourSymbolsFromPosition(string currentNumber, int index)
    {
        string currentCombination = String.Empty;

        currentCombination += currentNumber[index - 3];
        currentCombination += currentNumber[index - 2];
        currentCombination += currentNumber[index - 1];
        currentCombination += currentNumber[index];

        return currentCombination;
    }

    private static int[] ReadNumbersInputFromConsole(int numbersCount)
    {
        int[] allNumbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            allNumbers[i] = int.Parse(Console.ReadLine());
        }

        return allNumbers;
    }

    private static string CreateStringToSearchFor(long numberToGetBitsFrom)
    {
        long sequenceToSearchFor = numberToGetBitsFrom & 15;

        string result = Convert.ToString(sequenceToSearchFor, 2).PadLeft(4, '0');

        return result;
    }

    private static string[] ConvertNumbersToBinaryStrings(int[] numbers)
    {
        int numbersCount = numbers.Length;
        string[] binaryNumbers = new string[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            binaryNumbers[i] = Convert.ToString(numbers[i], 2).PadLeft(30, '0');
        }

        return binaryNumbers;
    }
}
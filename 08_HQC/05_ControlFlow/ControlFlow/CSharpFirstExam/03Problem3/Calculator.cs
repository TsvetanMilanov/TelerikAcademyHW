namespace NumbersCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Calculator
    {
        public static void Main()
        {
            List<long> numbers = ReadInputFromConsole();

            int numbersCount = numbers.Count;

            BigInteger allOddNumbersProduct = 1;
            BigInteger numberProduct = 1;

            if (numbersCount <= 10)
            {
                allOddNumbersProduct = CalculateProductOfOddNumbersInRange(numbers, 0, numbersCount);
                Console.WriteLine(allOddNumbersProduct);
            }

            if (numbersCount > 10)
            {
                allOddNumbersProduct = CalculateProductOfOddNumbersInRange(numbers, 0, 10);
                Console.WriteLine(allOddNumbersProduct);

                if (numbersCount - 10 <= 0)
                {
                    allOddNumbersProduct = CalculateProductOfAllNumbersInRange(numbers, 10, numbersCount);
                    Console.WriteLine(allOddNumbersProduct);
                }
                else
                {
                    BigInteger allNumbersProduct = CalculateProductOfOddNumbersInRange(numbers, 10, numbersCount);

                    Console.WriteLine(allNumbersProduct);
                }
            }
        }

        private static BigInteger CalculateProductOfAllNumbersInRange(List<long> numbers, int startIndex, int endIndex)
        {
            BigInteger numberProduct = 1;
            BigInteger allNumbersProduct = 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                BigInteger currentNumber = numbers[i];

                numberProduct = CalculateNumberProduct(currentNumber);

                allNumbersProduct *= numberProduct;
                numberProduct = 1;
            }

            return allNumbersProduct;
        }

        private static BigInteger CalculateProductOfOddNumbersInRange(List<long> numbers, int startIndex, int endIndex)
        {
            BigInteger numberProduct = 1;
            BigInteger allNumbersProduct = 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (i % 2 != 0)
                {
                    BigInteger currentNumber = numbers[i];

                    numberProduct = CalculateNumberProduct(currentNumber);
                }

                allNumbersProduct *= numberProduct;
                numberProduct = 1;
            }

            return allNumbersProduct;
        }

        private static BigInteger CalculateNumberProduct(BigInteger number)
        {
            BigInteger numberProduct = 1;

            if (number == 0)
            {
                numberProduct = 1;
            }
            else
            {
                while (number != 0)
                {
                    if (number % 10 == 0)
                    {
                        number /= 10;
                        continue;
                    }
                    else
                    {
                        numberProduct *= number % 10;
                    }

                    number /= 10;
                }
            }

            return numberProduct;
        }

        private static List<long> ReadInputFromConsole()
        {
            List<long> inputNumbers = new List<long>();

            string currentInputLine = Console.ReadLine();

            while (currentInputLine != "END")
            {
                long currentInputLineAsNumber = Convert.ToInt64(currentInputLine);
                inputNumbers.Add(currentInputLineAsNumber);

                currentInputLine = Console.ReadLine();
            }

            return inputNumbers;
        }
    }
}
namespace Numbers
{
    using System;

    public class Statistics
    {
        public static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());

            long biggestNumber = FindBiggestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(biggestNumber);

            long smallestNumber = FindSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);

            decimal arithmeticMean = (decimal)(firstNumber + secondNumber + thirdNumber) / 3m;
            Console.WriteLine("{0:F2}", arithmeticMean);
        }

        private static long FindSmallestNumber(long firstNumber, long secondNumber, long thirdNumber)
        {
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }

        private static long FindBiggestNumber(long firstNumber, long secondNumber, long thirdNumber)
        {
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}

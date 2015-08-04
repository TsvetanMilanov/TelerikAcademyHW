namespace StatisticsTask
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] inputData, int count)
        {
            double maximalValue = FindMaximalValueInData(inputData, count);

            PrintMaximalValue(maximalValue);

            double minimalValue = FindMinimalValueInData(inputData, count);

            PrintMinimalValue(minimalValue);

            double averageValue = CalculateAverageValueOfData(inputData, count);

            PrintAverageValue(averageValue);
        }

        private static void PrintAverageValue(double averageValue)
        {
            Console.WriteLine("The average value of the collection of data is: {0}", averageValue);
        }

        private static void PrintMinimalValue(double minimalValue)
        {
            Console.WriteLine("The minimal value in the collection of data is: {0}", minimalValue);
        }

        private static void PrintMaximalValue(double maximalValue)
        {
            Console.WriteLine("The maximal value in the collection of data is: {0}", maximalValue);
        }

        private static double CalculateAverageValueOfData(double[] inputData, int count)
        {
            double sumOfAllData = 0;

            for (int i = 0; i < count; i++)
            {
                sumOfAllData += inputData[i];
            }

            double averageValue = sumOfAllData / count;

            return averageValue;
        }

        private static double FindMinimalValueInData(double[] inputData, int count)
        {
            double minimalValue = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (inputData[i] < minimalValue)
                {
                    minimalValue = inputData[i];
                }
            }

            return minimalValue;
        }

        private static double FindMaximalValueInData(double[] inputData, int count)
        {
            double maximalValue = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (inputData[i] > maximalValue)
                {
                    maximalValue = inputData[i];
                }
            }

            return maximalValue;
        }
    }
}

namespace AdvancedMathCompare
{
    using System;

    using PerformanceTests;
    using SimpleMathCompare;

    public class AdvancedMathComparer
    {
        private const long RepetitionCount = 100000000;
        private const float FloatTestValue = 5.5f;
        private const double DoubleTestValue = 5.5d;
        private const decimal DecimalTestValue = 5.5M;

        public static void Main(string[] args)
        {
            Console.WriteLine("============== Square root results =============");
            PrintAllSqrtResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("=========== Natural logarithm results ===========");
            PrintAllNaturalLogarithmResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("================= Sinus results =================");
            PrintAllSinusResults();
        }

        private static void PrintAllSqrtResults()
        {
            TimeSpan floatTimeElapsed = SquareRootTest.MeasureTime(FloatTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                floatTimeElapsed,
                "Square root float",
                RepetitionCount);

            TimeSpan doubleTimeElapsed = SquareRootTest.MeasureTime(DoubleTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                doubleTimeElapsed,
                "Square root double",
                RepetitionCount);

            TimeSpan decimalTimeElapsed = SquareRootTest.MeasureTime(DecimalTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                decimalTimeElapsed,
                "Square root decimal",
                RepetitionCount);
        }

        private static void PrintAllNaturalLogarithmResults()
        {
            TimeSpan floatTimeElapsed = NaturalLogarithmTest
                                                    .MeasureTime(FloatTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                floatTimeElapsed,
                "Natural logarithm float",
                RepetitionCount);

            TimeSpan doubleTimeElapsed = NaturalLogarithmTest
                                                    .MeasureTime(DoubleTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                doubleTimeElapsed,
                "Natural logarithm double",
                RepetitionCount);

            TimeSpan decimalTimeElapsed = NaturalLogarithmTest
                                                    .MeasureTime(DecimalTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                decimalTimeElapsed,
                "Natural logarithm decimal",
                RepetitionCount);
        }

        private static void PrintAllSinusResults()
        {
            TimeSpan floatTimeElapsed = SinusTest
                                                    .MeasureTime(FloatTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                floatTimeElapsed,
                "Sinus float",
                RepetitionCount);

            TimeSpan doubleTimeElapsed = SinusTest
                                                    .MeasureTime(DoubleTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                doubleTimeElapsed,
                "Sinus double",
                RepetitionCount);

            TimeSpan decimalTimeElapsed = SinusTest
                                                    .MeasureTime(DecimalTestValue, RepetitionCount);
            SimpleMathCompare.ResultHelpers.PrintResults(
                decimalTimeElapsed,
                "Sinus decimal",
                RepetitionCount);
        }
    }
}

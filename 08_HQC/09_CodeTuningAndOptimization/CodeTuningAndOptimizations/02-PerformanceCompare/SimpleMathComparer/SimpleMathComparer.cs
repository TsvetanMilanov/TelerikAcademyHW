namespace SimpleMathCompare
{
    using System;

    using SimpleMathCompare.PerformanceTests;

    public class SimpleMathComparer
    {
        private const long RepetitionCount = 100000000;
        private const int FirstIntegerNumber = 5;
        private const int SecondIntegerNumber = 7;
        private const long FirstLongNumber = 6L;
        private const long SecondLongNumber = 3L;
        private const float FirstFloatNumber = 5.646164f;
        private const float SecondFloatNumber = 7.649984f;
        private const double FirstDoubleNumber = 6.646164d;
        private const double SecondDoubleNumber = 3.649984d;
        private const decimal FirstDecimalNumber = 2.649984M;
        private const decimal SecondDecimalNumber = 9.646164M;

        public static void Main(string[] args)
        {
            Console.WriteLine("=============== Addition results ===============\n");
            PrintAllAdditionResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("============== Subtraction results =============\n");
            PrintAllSubtractionResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("============= Incremention results =============\n");
            PrintAllIncrementionResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("============ Multiplication results ============\n");
            PrintAllMultiplicationResults();
            Console.WriteLine("\n\n");

            Console.WriteLine("=============== Division results ===============\n");
            PrintAllDivisionResults();
        }

        private static void PrintAllAdditionResults()
        {
            TimeSpan integerTimeElapsed = AdditionTest
                .MeasureTime(FirstIntegerNumber, SecondIntegerNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Adding integers", RepetitionCount);

            TimeSpan longTimeElapsed = AdditionTest
                .MeasureTime(FirstLongNumber, SecondLongNumber, RepetitionCount);
            ResultHelpers.PrintResults(longTimeElapsed, "Adding longs", RepetitionCount);

            TimeSpan floatTimeElapsed = AdditionTest
                .MeasureTime(FirstFloatNumber, SecondFloatNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Adding floats", RepetitionCount);

            TimeSpan doubleTimeElapsed = AdditionTest
                .MeasureTime(FirstDoubleNumber, SecondDoubleNumber, RepetitionCount);
            ResultHelpers.PrintResults(doubleTimeElapsed, "Adding doubles", RepetitionCount);

            TimeSpan decimalTimeElapsed = AdditionTest
                .MeasureTime(FirstDecimalNumber, SecondDecimalNumber, RepetitionCount);
            ResultHelpers.PrintResults(decimalTimeElapsed, "Adding decimals", RepetitionCount);
        }

        private static void PrintAllSubtractionResults()
        {
            TimeSpan integerTimeElapsed = SubtractionTest
                .MeasureTime(FirstIntegerNumber, SecondIntegerNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Subtracting integers", RepetitionCount);

            TimeSpan longTimeElapsed = SubtractionTest
                .MeasureTime(FirstLongNumber, SecondLongNumber, RepetitionCount);
            ResultHelpers.PrintResults(longTimeElapsed, "Subtracting longs", RepetitionCount);

            TimeSpan floatTimeElapsed = SubtractionTest
                .MeasureTime(FirstFloatNumber, SecondFloatNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Subtracting floats", RepetitionCount);

            TimeSpan doubleTimeElapsed = SubtractionTest
                .MeasureTime(FirstDoubleNumber, SecondDoubleNumber, RepetitionCount);
            ResultHelpers.PrintResults(doubleTimeElapsed, "Subtracting doubles", RepetitionCount);

            TimeSpan decimalTimeElapsed = SubtractionTest
                .MeasureTime(FirstDecimalNumber, SecondDecimalNumber, RepetitionCount);
            ResultHelpers.PrintResults(decimalTimeElapsed, "Subtracting decimals", RepetitionCount);
        }

        private static void PrintAllIncrementionResults()
        {
            TimeSpan integerTimeElapsed = IncrementionTest
                .MeasureTime(FirstIntegerNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Incrementing integers", RepetitionCount);

            TimeSpan longTimeElapsed = IncrementionTest
                .MeasureTime(FirstLongNumber, RepetitionCount);
            ResultHelpers.PrintResults(longTimeElapsed, "Incrementing longs", RepetitionCount);

            TimeSpan floatTimeElapsed = IncrementionTest
                .MeasureTime(FirstFloatNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Incrementing floats", RepetitionCount);

            TimeSpan doubleTimeElapsed = IncrementionTest
                .MeasureTime(FirstDoubleNumber, RepetitionCount);
            ResultHelpers.PrintResults(doubleTimeElapsed, "Incrementing doubles", RepetitionCount);

            TimeSpan decimalTimeElapsed = IncrementionTest
                .MeasureTime(FirstDecimalNumber, RepetitionCount);
            ResultHelpers.PrintResults(decimalTimeElapsed, "Incrementing decimals", RepetitionCount);
        }

        private static void PrintAllMultiplicationResults()
        {
            TimeSpan integerTimeElapsed = MultiplicationTest
                .MeasureTime(FirstIntegerNumber, SecondIntegerNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Multiplicating integers", RepetitionCount);

            TimeSpan longTimeElapsed = MultiplicationTest
                .MeasureTime(FirstLongNumber, SecondLongNumber, RepetitionCount);
            ResultHelpers.PrintResults(longTimeElapsed, "Multiplicating longs", RepetitionCount);

            TimeSpan floatTimeElapsed = MultiplicationTest
                .MeasureTime(FirstFloatNumber, SecondFloatNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Multiplicating floats", RepetitionCount);

            TimeSpan doubleTimeElapsed = MultiplicationTest
                .MeasureTime(FirstDoubleNumber, SecondDoubleNumber, RepetitionCount);
            ResultHelpers.PrintResults(doubleTimeElapsed, "Multiplicating doubles", RepetitionCount);

            TimeSpan decimalTimeElapsed = MultiplicationTest
                .MeasureTime(FirstDecimalNumber, SecondDecimalNumber, RepetitionCount);
            ResultHelpers.PrintResults(decimalTimeElapsed, "Multiplicating decimals", RepetitionCount);
        }

        private static void PrintAllDivisionResults()
        {
            TimeSpan integerTimeElapsed = DivisionTest
                .MeasureTime(FirstIntegerNumber, SecondIntegerNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Dividing integers", RepetitionCount);

            TimeSpan longTimeElapsed = DivisionTest
                .MeasureTime(FirstLongNumber, SecondLongNumber, RepetitionCount);
            ResultHelpers.PrintResults(longTimeElapsed, "Dividing longs", RepetitionCount);

            TimeSpan floatTimeElapsed = DivisionTest
                .MeasureTime(FirstFloatNumber, SecondFloatNumber, RepetitionCount);
            ResultHelpers.PrintResults(integerTimeElapsed, "Dividing floats", RepetitionCount);

            TimeSpan doubleTimeElapsed = DivisionTest
                .MeasureTime(FirstDoubleNumber, SecondDoubleNumber, RepetitionCount);
            ResultHelpers.PrintResults(doubleTimeElapsed, "Dividing doubles", RepetitionCount);

            TimeSpan decimalTimeElapsed = DivisionTest
                .MeasureTime(FirstDecimalNumber, SecondDecimalNumber, RepetitionCount);
            ResultHelpers.PrintResults(decimalTimeElapsed, "Dividing decimals", RepetitionCount);
        }
    }
}

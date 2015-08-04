namespace AdvancedMathCompare.PerformanceTests
{
    using System;
    using System.Diagnostics;

    public static class SquareRootTest
    {
        public static TimeSpan MeasureTime(float number, long repetitionCount)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                Math.Sqrt(number);
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(double number, long repetitionCount)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                Math.Sqrt(number);
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(decimal number, long repetitionCount)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            double convertedValue = (double)number;

            for (long i = 0; i < repetitionCount; i++)
            {
                Math.Sqrt(convertedValue);
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }
    }
}

namespace SimpleMathCompare.PerformanceTests
{
    using System;
    using System.Diagnostics;

    public static class IncrementionTest
    {
        public static TimeSpan MeasureTime(int firstNumber, long repetitionCount)
        {
            long sum = 0;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                sum = firstNumber++;
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(long firstNumber, long repetitionCount)
        {
            long sum = 0L;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                sum = firstNumber++;
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(float firstNumber, long repetitionCount)
        {
            float sum = 0f;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                sum = firstNumber++;
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(double firstNumber, long repetitionCount)
        {
            double sum = 0d;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                sum = firstNumber++;
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }

        public static TimeSpan MeasureTime(decimal firstNumber, long repetitionCount)
        {
            decimal sum = 0M;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (long i = 0; i < repetitionCount; i++)
            {
                sum = firstNumber++;
            }

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }
    }
}

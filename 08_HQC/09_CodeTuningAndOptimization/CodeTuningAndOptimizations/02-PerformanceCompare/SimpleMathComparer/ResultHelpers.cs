namespace SimpleMathCompare
{
    using System;

    public static class ResultHelpers
    {
        public static void PrintResults(TimeSpan timeElapsed, string testDescription, long repetitionsCount)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Test: {0}", testDescription);
            Console.WriteLine("Repetitions count: {0} times.", repetitionsCount);
            Console.WriteLine("Time elapsed: {0} s.", timeElapsed.TotalSeconds);
            Console.WriteLine("================================================");
            Console.WriteLine();
        }
    }
}

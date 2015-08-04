namespace SortingAlgorithmsCompare
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using SimpleMathCompare;

    public class SortingAlgorithmsComparer
    {
        private const long RepetitionsCount = 500000L;

        private delegate T[] MethodToTest<T>(T[] array) where T : IComparable;

        public static void Main(string[] args)
        {
            int[] randomIntArray = new int[] { 1, 2, 5, 2, 5, 8, 54, 33, 55, 42, 2 };
            double[] randomDoubleArray =
                new double[] { 245234.53453, 1.134, 3.34234, 1.2, 7.34124, 5.3241234, 24.234 };
            string[] randomStringArray =
                new string[] { "sdafasd", "qweqwe", "asdfsd", "wefg", "fhydf", "asg" };

            int[] sortedIntArray = SortingAlgorithms.QuickSort(randomIntArray);
            double[] sortedDoubleArray = SortingAlgorithms.QuickSort(randomDoubleArray);
            string[] sortedStringArray = SortingAlgorithms.QuickSort(randomStringArray);

            int[] reversedSortedIntArray = SortingAlgorithms.QuickSort(randomIntArray).Reverse().ToArray();
            double[] reversedSortedDoubleArray =
                SortingAlgorithms.QuickSort(randomDoubleArray).Reverse().ToArray();
            string[] reversedSortedStringArray =
                SortingAlgorithms.QuickSort(randomStringArray).Reverse().ToArray();

            ArrayHolder<int> integerArrayHolder =
                new ArrayHolder<int>(randomIntArray, sortedIntArray, reversedSortedIntArray);
            ArrayHolder<double> doubleArrayHolder =
                new ArrayHolder<double>(randomDoubleArray, sortedDoubleArray, reversedSortedDoubleArray);
            ArrayHolder<string> stringArrayHolder =
                new ArrayHolder<string>(randomStringArray, sortedStringArray, reversedSortedStringArray);

            Console.WriteLine("---------------- Insertion sort ----------------");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.InsertionSort, integerArrayHolder, "InsertionSort");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.InsertionSort, doubleArrayHolder, "InsertionSort");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.InsertionSort, stringArrayHolder, "InsertionSort");

            Console.WriteLine("---------------- Selection sort ----------------");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.SelectionSort, integerArrayHolder, "SelectionSort");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.SelectionSort, doubleArrayHolder, "SelectionSort");
            TestSortingAlgorithmPerformance(
                SortingAlgorithms.SelectionSort, stringArrayHolder, "SelectionSort");

            Console.WriteLine("------------------ Quick sort ------------------");
            TestSortingAlgorithmPerformance(SortingAlgorithms.QuickSort, integerArrayHolder, "QuickSort");
            TestSortingAlgorithmPerformance(SortingAlgorithms.QuickSort, doubleArrayHolder, "QuickSort");
            TestSortingAlgorithmPerformance(SortingAlgorithms.QuickSort, stringArrayHolder, "QuickSort");
        }

        private static void TestSortingAlgorithmPerformance<T>(
            MethodToTest<T> methodToTest, ArrayHolder<T> arrayHolder, string algorithmName)
            where T : IComparable
        {
            string dataType = arrayHolder.SortedArray
                .ToString()
                .Split('.')[1];

            TimeSpan sortRandomElapsedTime =
                MeasureTimeToRunMethod(methodToTest, arrayHolder.RandomArray, RepetitionsCount);
            string randomTestDescription =
                string.Format("{0} with random {1}", algorithmName, dataType);
            ResultHelpers
                .PrintResults(sortRandomElapsedTime, randomTestDescription, RepetitionsCount);

            TimeSpan sortSortedElapsedTime =
                MeasureTimeToRunMethod(methodToTest, arrayHolder.SortedArray, RepetitionsCount);
            string sortedTestDescription =
                string.Format("{0} with sorted {1}", algorithmName, dataType);
            ResultHelpers
                .PrintResults(sortSortedElapsedTime, sortedTestDescription, RepetitionsCount);

            TimeSpan sortReversedElapsedTime =
                MeasureTimeToRunMethod(methodToTest, arrayHolder.ReversedSortedArray, RepetitionsCount);
            string reversedSortedTestDescription =
                string.Format("{0} with reversed sorted {1}", algorithmName, dataType);
            ResultHelpers
                .PrintResults(sortReversedElapsedTime, reversedSortedTestDescription, RepetitionsCount);
        }

        private static TimeSpan MeasureTimeToRunMethod<T>(
            MethodToTest<T> method, T[] array, long repetitionsCount) where T : IComparable
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (long i = 0; i < repetitionsCount; i++)
            {
                method(array);
            }

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            return elapsedTime;
        }
    }
}

namespace Assertions
{
    using System.Diagnostics;

    public static class DebugAssertionHelper
    {
        public static void CheckArraysLength<T>(T[] arr)
        {
            Debug.Assert(arr.Length > 0, "Arrays length must be greater than or equal to 1!");
        }

        public static void ValidateStartAndEndIndexesInArray<T>(T[] arr, int startIndex, int endIndex)
        {
            DebugAssertionHelper.CheckIfIndexIsInBoundsOfArray(arr, startIndex, "Start index");
            DebugAssertionHelper.CheckIfIndexIsInBoundsOfArray(arr, endIndex, "End index");
            DebugAssertionHelper.CompareStartAndEndIndexInArray(startIndex, endIndex);
        }

        private static void CheckIfIndexIsInBoundsOfArray<T>(T[] arr, int index, string propertyName)
        {
            int arraysLength = arr.Length;
            string errorMessage = string.Format(
                                                "{0} must be between 0 and {1}!",
                                                propertyName,
                                                arraysLength - 1);

            Debug.Assert(0 <= index && index < arraysLength, errorMessage);
        }

        private static void CompareStartAndEndIndexInArray(int startIndex, int endIndex)
        {
            Debug.Assert(startIndex < endIndex, "Start index must be less than the end index!");
        }
    }
}

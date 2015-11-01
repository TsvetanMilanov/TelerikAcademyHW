namespace LongestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var sequence = new List<int> { 1, 52, 2, 2, 953, 2, 5, 156, 7, 7, 7, 4, 6, 6, 875, 7, 547 };

            IList<int> longestSubsequence = FindLongestSubsequenceOfEqualNumbers(sequence);

            Console.WriteLine("The longest subsequence of equal elements is:");
            Console.WriteLine(string.Join(", ", longestSubsequence));

            Console.WriteLine();
            Console.WriteLine("Test results: ");

            var firstInput = new List<int> { 1, 1, 1, 1, 2, 2, 2 };
            var firstResult = new List<int> { 1, 1, 1, 1 };
            bool firstTestResult = CheckIfSolutionIsCorrect(firstInput, firstResult, FindLongestSubsequenceOfEqualNumbers);
            Console.WriteLine("First test: {0}", firstTestResult == true ? "Pass" : "Fail");

            var secondInput = new List<int> { 1, 1, 2, 2, 2 };
            var secondResult = new List<int> { 2, 2, 2 };
            bool secondTestResult = CheckIfSolutionIsCorrect(secondInput, secondResult, FindLongestSubsequenceOfEqualNumbers);
            Console.WriteLine("Second test: {0}", secondTestResult == true ? "Pass" : "Fail");

            var thirdInput = new List<int> { 1, 2, 3, 4, 5 };
            var thirdResult = new List<int> { 5 };
            bool thirdTestResult = CheckIfSolutionIsCorrect(thirdInput, thirdResult, FindLongestSubsequenceOfEqualNumbers);
            Console.WriteLine("Third test: {0}", thirdTestResult == true ? "Pass" : "Fail");
        }

        private static IList<int> FindLongestSubsequenceOfEqualNumbers(IList<int> sequence)
        {
            var longestSubsequence = new List<int>();
            var currentSequence = new List<int>();

            for (int i = 1; i < sequence.Count; i++)
            {
                int previousNumber = sequence[i - 1];
                int currentNumber = sequence[i];

                if (i == 1)
                {
                    currentSequence.Add(previousNumber);
                }


                if (!currentSequence.Contains(currentNumber))
                {
                    if (longestSubsequence.Count <= currentSequence.Count)
                    {
                        longestSubsequence = currentSequence.ToList();
                    }

                    currentSequence = new List<int>();
                }

                currentSequence.Add(currentNumber);
            }

            if (longestSubsequence.Count <= currentSequence.Count)
            {
                longestSubsequence = currentSequence.ToList();
            }

            if (longestSubsequence.Count <= 0 && sequence.Count == 1)
            {
                longestSubsequence.Add(sequence[0]);
            }

            return longestSubsequence;
        }

        private static bool CheckIfSolutionIsCorrect(IList<int> input, IList<int> expected, Func<IList<int>, IList<int>> solution)
        {
            var result = solution(input);

            return result.SequenceEqual(expected);
        }
    }
}
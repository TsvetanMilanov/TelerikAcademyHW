namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            Validator.CheckIfNull(arr, "Subsequence array");
            Validator.CheckIfCollectionIsEmpty(arr, "Subsequence array");
            Validator.CheckIfValueIsInRange(startIndex, 0, arr.Length, "Subsequence start index");
            Validator.CheckIfValueIsInRange(count, 1, arr.Length, "Subsequence start index");

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            Validator.CheckIfStringIsValid(str, "ExtractEnding string");
            Validator.CheckIfCountIsBiggerThanStringLength(count, str, "Extract ending");

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckIsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            try
            {
                var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);

                var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(string.Join(" ", subarr));

                var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(string.Join(" ", allarr));

                var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(string.Join(" ", emptyarr));
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.ParamName);
            }

            try
            {
                Console.WriteLine(ExtractEnding("I love C#", 2));
                Console.WriteLine(ExtractEnding("Nakov", 4));
                Console.WriteLine(ExtractEnding("beer", 4));
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.ParamName);
            }

            int firstNumber = 23;
            int secondNumber = 33;
            bool firstNumberIsPrime = CheckIsPrime(firstNumber);
            bool secondNumberIsPrime = CheckIsPrime(secondNumber);

            PrintIsPrime(firstNumberIsPrime, firstNumber);
            PrintIsPrime(secondNumberIsPrime, secondNumber);

            List<Exam> peterExams = new List<Exam>()
                                                 {
                                                     new SimpleMathExam(2),
                                                     new CSharpExam(55),
                                                     new CSharpExam(100),
                                                     new SimpleMathExam(1),
                                                     new CSharpExam(0),
                                                 };
            try
            {
                Student peter = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peter.CalculateAverageExamResultInPercents();
                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.ParamName);
            }
        }

        private static void PrintIsPrime(bool isPrime, int number)
        {
            if (isPrime == true)
            {
                Console.WriteLine("{0} is prime.", number);
            }
            else
            {
                Console.WriteLine("{0} is not prime", number);
            }
        }
    }
}
namespace IEnumerableProblem
{
    using System;
    using System.Collections.Generic;

    public class IEnumMain
    {
        public static void Main(string[] args)
        {
            List<int> testList = new List<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            int sum = testList.Sum<int>();

            int product = testList.Product<int>();

            int min = testList.Min<int>();

            int max = testList.Max<int>();

            var average = testList.Average();

            Console.WriteLine("The sum of {0} is: {1}", string.Join(" + ", testList), sum);

            Console.WriteLine("The product of {0} is: {1}", string.Join(" * ", testList), product);

            Console.WriteLine("The minimal item in {0} is: {1}", string.Join(", ", testList), min);

            Console.WriteLine("The maximal item in {0} is: {1}", string.Join(", ", testList), max);

            Console.WriteLine("The average of {0} is: {1}", string.Join(", ", testList), average);
        }
    }
}

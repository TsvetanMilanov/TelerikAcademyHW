
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */

namespace _09SortingArray
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            int[] numbers = { 24, 342, 5234, 5, 234, 134, 5, 23454, 35, 3425, 7 };

            Console.WriteLine("Enter the start position:");
            int start = int.Parse(Console.ReadLine());
            int end = numbers.GetLength(0);

            PrintArray(numbers);

            int biggestNumber = numbers[FindBiggestNumberInArray(numbers, start, end)];

            Console.WriteLine("The biggest number from position: {0} is {1}", start, biggestNumber);

            SortArray(numbers);
        }

        private static void SortArray(int[] numbers)
        {
            int[] ascending = (int[])numbers.Clone();
            int[] descending = (int[])numbers.Clone();
            int temp = 0;
            int biggestNumberIndex = 0;

            //Start filling the array from the last index and finding the biggest number in it.
            for (int i = ascending.GetLength(0) - 1; i >= 0; i--)
            {
                biggestNumberIndex = FindBiggestNumberInArray(ascending, 0, i + 1);

                temp = ascending[i];

                ascending[i] = ascending[biggestNumberIndex];

                ascending[biggestNumberIndex] = temp;
            }
            Console.WriteLine();

            Console.WriteLine("The Array sorted in ascending order is:\n{0}", string.Join(", ", ascending));


            //Start filling the array from the first index and finding the biggest number in it.
            for (int i = 0; i < descending.GetLength(0); i++)
            {
                biggestNumberIndex = FindBiggestNumberInArray(descending, i, descending.GetLength(0));

                temp = descending[i];

                descending[i] = descending[biggestNumberIndex];

                descending[biggestNumberIndex] = temp;
            }
            Console.WriteLine();

            Console.WriteLine("The Array sorted in descenging order is:\n{0}", string.Join(", ", descending));
            Console.WriteLine();
        }



        private static int FindBiggestNumberInArray(int[] numbers, int start, int end)
        {
            int biggestNumber = int.MinValue;

            int biggestNumberIndex = 0;

            for (int i = start; i < end; i++)
            {
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                    biggestNumberIndex = i;
                }
            }

            return biggestNumberIndex;
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine("The array is:\n");

            string result = string.Join(", ", numbers);

            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static int[] InitArray()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return array;
        }

    }
}

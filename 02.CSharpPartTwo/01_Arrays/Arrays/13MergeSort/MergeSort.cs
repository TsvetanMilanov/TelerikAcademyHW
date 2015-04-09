using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.
 */

namespace _13MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            //If you want to enter your own array use this the row below.
            //int[] array = initArray();

            int[] array = { 5, 2, 7, 4, 9, 1, 0, 4, 3 };
            int sizeOfArray = array.Length;

            Console.WriteLine("The unsorted array is:");
            PrintArray(array);

            //Sort the array.
            array = MergeSortArray(array);
            Console.WriteLine("The sorted array is:");
            PrintArray(array);
        }

        static int[] InitArray()
        {
            //Initializes an int array.

            Console.Write("Enter the size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            //Prints an int array.

            string result = string.Join(", ", array);

            Console.WriteLine("\n{0}\n", result);
        }

        static int[] MergeSortArray(int[] array)
        {
            //Sorts int array useing the merge sort algorythm.

            int sizeOfArray = array.Length;

            if (sizeOfArray == 1)
            {
                return array;
            }


            int middle = sizeOfArray / 2;

            int[] leftArray = new int[middle];

            int[] rightArray;

            if (sizeOfArray % 2 == 0)
            {
                rightArray = new int[middle];
            }
            else
            {
                rightArray = new int[middle + 1];
            }

            int[] result = new int[sizeOfArray];

            //Divide the numbers in the two arrays - left and right.
            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = 0, j = middle; j < sizeOfArray; i++, j++)
            {
                rightArray[i] = array[j];
            }

            //Divide, divide, divide...
            leftArray = MergeSortArray(leftArray);
            rightArray = MergeSortArray(rightArray);

            result = MergeArrays(leftArray, rightArray);

            return result;
        }

        static int[] MergeArrays(int[] leftArray, int[] rightArray)
        {
            //Merges two arrays for the sorting.

            int sizeOfResult = leftArray.Length + rightArray.Length;
            int[] result = new int[sizeOfResult];

            int indexLeft = 0;
            int indexRight = 0;
            int indexResult = 0;

            while (indexLeft < leftArray.Length || indexRight < rightArray.Length)
            {
                if (indexLeft < leftArray.Length && indexRight < rightArray.Length)
                {
                    if (leftArray[indexLeft] <= rightArray[indexRight])
                    {
                        result[indexResult] = leftArray[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = rightArray[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < leftArray.Length)
                {
                    result[indexResult] = leftArray[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < rightArray.Length)
                {
                    result[indexResult] = rightArray[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }

    }
}
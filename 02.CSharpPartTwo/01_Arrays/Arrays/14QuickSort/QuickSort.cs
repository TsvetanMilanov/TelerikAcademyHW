using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.
 */

namespace _14QuickSort
{
    class QuickSort
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
            QuickSortArray(array, 0, sizeOfArray - 1);

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

        static void QuickSortArray(int[] array, int left, int right)
        {
            int leftBorder = left;
            int rightBorder = right;

            int temp = 0;

            int middle = (left + right) / 2;

            int pivot = array[middle];

            while (leftBorder <= rightBorder)
            {
                while (array[leftBorder] < pivot)
                {
                    leftBorder++;
                }
                while (array[rightBorder] > pivot)
                {
                    rightBorder--;
                }

                if (leftBorder <= rightBorder)
                {
                    temp = array[leftBorder];
                    array[leftBorder] = array[rightBorder];
                    array[rightBorder] = temp;
                    leftBorder++;
                    rightBorder--;
                }
            }

            if (left < rightBorder)
            {
                QuickSortArray(array, left, rightBorder);
            }

            if (leftBorder < right)
            {
                QuickSortArray(array, leftBorder, right);
            }
        }

    }
}

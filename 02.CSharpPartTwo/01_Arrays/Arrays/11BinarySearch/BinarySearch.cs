using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the wanted number:");
            //int x = int.Parse(Console.ReadLine());
            //int[] array = InitArray();

            int x = 8;
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sizeOfArray = array.Length;

            Array.Sort(array);

            if (x > array[sizeOfArray - 1] || x < array[0])
            {
                Console.WriteLine("The number was not found in the array.");
                return;
            }

            int start = 0;
            int end = sizeOfArray;
            int middle = (end - start) / 2;

            int position = 0;

            while (middle != 0)
            {
                if (x == array[middle])
                {
                    position = middle;
                    break;
                }
                else if (x < array[middle])
                {
                    end = middle;
                    middle = (end - start) / 2;
                }
                else if (x > array[middle])
                {
                    start = middle;
                    middle = ((end - start) / 2) + start;
                }
            }

            Console.WriteLine("Foud \"{0}\" at positon: {1}", x, position);
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

            Console.WriteLine();

            return array;
        }

    }
}

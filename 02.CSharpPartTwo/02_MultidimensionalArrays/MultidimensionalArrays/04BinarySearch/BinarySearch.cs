using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and
using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

namespace _04BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the wanted number:");
            int k = int.Parse(Console.ReadLine());

            //Console input.
            //int[] array = InitArray();

            int[] array = { 7, 0, 3, 3, 3, 2, 9, 6, 1, 8, 5, 800 };
            int sizeOfArray = array.Length;

            Array.Sort(array);

            int wantedNumber = k;

            bool foundNumber = false;

            int largestNumber = 0;

            while (!foundNumber)
            {
                int result = Array.BinarySearch(array, wantedNumber);

                if (result >= 0)
                {
                    largestNumber = array[result];
                    foundNumber = true;
                }
                else
                {
                    wantedNumber--;
                }
            }


            Console.WriteLine("The array is: {0}\n", string.Join(", ", array));

            Console.WriteLine("The largest number <= {0} in the array is: {1}\n", k, largestNumber);
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

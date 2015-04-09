
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
 */

namespace _06FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            int[] numbers = { 24, 342, 5234, 5, 234, 134, 5, 23454, 35, 3425, 7 };

            PrintArray(numbers);

            int index = FindFirstElement(numbers);

            if (index == -1)
            {
                Console.WriteLine("There is no such item in the array.");
            }
            else
            {
                Console.WriteLine("The first number was found at position -> {0} and it is -> {1}.", index, numbers[index]);
            }
        }

        private static int FindFirstElement(int[] numbers)
        {
            int position = -1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                position = CheckNeighbours(numbers, i);
                if (position != -1)
                {
                    return position;
                }
            }

            return position;
        }

        private static int CheckNeighbours(int[] array, int index)
        {
            if (index < 0 || index >= array.GetLength(0))
            {
                return -1;
            }

            if (index == array.GetLength(0) - 1)
            {
                return -1;
            }

            if (index == 0)
            {
                return -1;
            }

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return index;
            }

            return -1;
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

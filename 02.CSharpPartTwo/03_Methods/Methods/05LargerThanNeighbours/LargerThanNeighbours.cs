using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            int[] numbers = { 24, 342, 5234, 5, 234, 134, 5, 23454, 35, 3425, 7 };

            PrintArray(numbers);

            CheckNeighbours(numbers);
        }

        private static void CheckNeighbours(int[] array)
        {
            Console.WriteLine("Enter the positionn of the element:");

            int position = int.Parse(Console.ReadLine());

            if (position < 0 || position >= array.GetLength(0))
            {
                Console.WriteLine("There is no such position!");
                return;
            }

            if (position == array.GetLength(0) - 1)
            {
                Console.WriteLine("There is no neighbour on the right.");
                return;
            }

            if (position == 0)
            {
                Console.WriteLine("There is no neighbour on the left.");
                return;
            }

            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("The element in position {0} is {1} and it is bigger than it's neighbours - {2} and {3}.", position, array[position], array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("The element in position {0} is {1} and it is NOT bigger than it's neighbours - {2} and {3}.", position, array[position], array[position - 1], array[position + 1]);
            }
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
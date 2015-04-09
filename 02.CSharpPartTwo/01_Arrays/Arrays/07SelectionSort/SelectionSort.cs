using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */

namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            //Test array.
            int[] numbers = { 10, 9, 5, 4, 6, 2, 7, 8, 3, 1, 2, 3, -8, 8 };

            int sizeOfArray = numbers.Length;

            int temp = 0;
            int minIndex = 0;

            //Sort the array;
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < sizeOfArray; j++)
                {
                    if (numbers[minIndex] > numbers[j])
                    {
                        minIndex = j;
                    }
                }
                if (numbers[i] > numbers[minIndex])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = temp;
                }
            }

            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
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

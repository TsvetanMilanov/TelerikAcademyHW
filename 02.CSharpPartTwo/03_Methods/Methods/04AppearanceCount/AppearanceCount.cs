using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */

namespace _04AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] numbers = InitArray();

            int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

            PrintArray(numbers);

            CountAppearance(numbers);
        }

        private static void CountAppearance(int[] array)
        {
            Console.WriteLine("Enter the number you are looking for:");
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            foreach (int currentNumber in array)
            {
                if (currentNumber == number)
                {
                    counter++;
                }
            }

            Console.WriteLine("Found the number {0} -> {1} times in the array.", number, counter);
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine("\nThe array is:\n");

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

            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */

namespace _02CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            //If you want to use your own arrays entered from the console use the commented part below.
            //int[] firstArray = InitArray();
            //int sizeOfFirstArray = firstArray.Length;

            //int[] secondArray = InitArray();
            //int sizeOfSecondArray = secondArray.Length;

            int sizeOfFirstArray = 10;
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sizeOfSecondArray = 10;
            int[] secondArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool areEqual = true;

            //Compare the two arrays.
            if (sizeOfFirstArray != sizeOfSecondArray)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < sizeOfFirstArray; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine("The arrays are equal.");
            }
            else
            {
                Console.WriteLine("The arrays are not equal.");
            }

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

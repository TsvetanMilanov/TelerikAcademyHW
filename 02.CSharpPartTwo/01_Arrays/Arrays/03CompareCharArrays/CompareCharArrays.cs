using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */

namespace _03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            //Use this if you want to use your own char arrays entered from the console.
            //char[] firstArray = InitArray();
            //int sizeOfFirstArray = firstArray.Length;


            //char[] secondArray = InitArray();
            //int sizeOfSecondArray = secondArray.Length;

            int sizeOfFirstArray = 10;
            char[] firstArray = { 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'k', 'l' };

            int sizeOfSecondArray = 10;
            char[] secondArray = { 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'k', 'l' };



            bool areEqual = true;

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

        static char[] InitArray()
        {
            //Initializes char array.

            Console.Write("Enter the size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            char[] array = new char[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            return array;
        }

    }
}

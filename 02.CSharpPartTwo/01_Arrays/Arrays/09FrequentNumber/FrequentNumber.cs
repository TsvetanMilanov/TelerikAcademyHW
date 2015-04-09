using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
 */

namespace _09FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] array = InitArray();

            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int sizeOfArray = array.Length;


            int currentNumber = 0;
            int number = 0;
            int counter;
            int maxCount = 0;

            for (int i = 0; i < sizeOfArray; i++)
            {
                currentNumber = array[i];
                counter = 1;
                for (int j = 0; j < sizeOfArray; j++)
                {
                    //If the indexes of the array from the two cycles are equal don't continue without incremmenting the counter
                    if (i == j)
                    {
                        continue;
                    }
                    if (currentNumber == array[j])
                    {
                        counter++;
                    }
                }
                if (maxCount < counter)
                {
                    maxCount = counter;
                    number = currentNumber;
                }
            }

            Console.WriteLine("{0} ({1} times)", number, maxCount);
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

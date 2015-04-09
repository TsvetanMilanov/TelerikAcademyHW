using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 */

namespace _04MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            //Console input:
            //int[] array = InitArray();
            //int sizeOfArray = array.Length;

            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int sizeOfArray = array.Length;


            int currentElement = 0;

            List<int> sequence = new List<int>();
            int counter = 0;
            int maxCount = 0;
            int numberOfSequence = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentElement = array[i];
                counter = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (i == 0)
                {
                    numberOfSequence = currentElement;
                    maxCount = counter;
                }
                else
                {
                    if (counter > maxCount)
                    {
                        numberOfSequence = currentElement;
                        maxCount = counter;
                    }
                }
            }

            for (int i = 0; i <= maxCount; i++)
            {
                sequence.Add(numberOfSequence);
            }

            string result = string.Join(", ", sequence);

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

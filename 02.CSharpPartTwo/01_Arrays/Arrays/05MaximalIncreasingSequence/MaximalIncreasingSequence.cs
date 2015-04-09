using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
 */

namespace _05MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] array = InitArray();
            //int sizeOfArray = array.Length;

            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int sizeOfArray = array.Length;


            int currentElement = 0;
            int nextElement = 0;

            //Creating string array which will contain all the increasing sequences.
            string[] sequences = new string[100];

            //If there is only one number, it will be the answer.
            if (sizeOfArray == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            //Find all the increasing sequences.
            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {
                currentElement = array[i];
                nextElement = array[i + 1];

                if (i == 0)
                {
                    sequences[j] += currentElement;
                    sequences[j] += ' ';

                    if (nextElement - currentElement == 1)
                    {
                        sequences[j] += nextElement;
                        sequences[j] += ' ';
                    }
                    else
                    {
                        j++;
                        sequences[j] += nextElement;
                        sequences[j] += ' ';
                    }
                }
                else
                {
                    if (nextElement - currentElement == 1)
                    {
                        sequences[j] += nextElement;
                        sequences[j] += ' ';
                    }
                    else
                    {
                        j++;
                        sequences[j] += nextElement;
                        sequences[j] += ' ';
                    }
                }
            }

            int count = 0;
            int maxCount = 0;
            int indexOfMaxCount = 0;


            //Count the numbers in each sequence and find the longest one.
            for (int i = 0; i < sequences.Length; i++)
            {
                count = 0;
                if (i == 0)
                {
                    for (int j = 0; j < sequences[i].Length; j++)
                    {
                        if (sequences[i][j] == ' ')
                        {
                            count++;
                        }
                    }
                    indexOfMaxCount = i;
                    maxCount = count;
                    count = 0;
                }
                else
                {
                    if (sequences[i] == null)
                    {
                        break;
                    }
                    for (int j = 0; j < sequences[i].Length; j++)
                    {
                        if (sequences[i][j] == ' ')
                        {
                            count++;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        indexOfMaxCount = i;
                    }
                }
            }

            Console.WriteLine(sequences[indexOfMaxCount]);
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

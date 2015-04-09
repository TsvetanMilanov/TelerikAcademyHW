using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
 */

namespace _10FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            //For console input:
            //Console.WriteLine("Enter the value for S:");
            //int s = int.Parse(Console.ReadLine());
            //int[] array = InitArray();

            int s = 11;
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };


            bool flagHasSum = false;


            int sum = 0;
            List<int> sequence = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                sequence.Add(array[i]);
                sum = 0;
                sum += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (sum == s)
                    {
                        flagHasSum = true;
                        break;
                    }

                    sum += array[j];

                    if (sum < s)
                    {
                        sequence.Add(array[j]);
                    }
                    else if (sum == s)
                    {
                        sequence.Add(array[j]);
                        flagHasSum = true;
                        break;
                    }
                    else
                    {
                        sequence.Clear();
                    }
                }

                if (sum == s)
                {
                    break;
                }
                else if (sum < s)
                {
                    sequence.Clear();
                }
                else
                {
                    sequence.Clear();
                }
            }


            if (flagHasSum)
            {
                string result = string.Join(", ", sequence);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no sum = {0} in this array.", s);
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

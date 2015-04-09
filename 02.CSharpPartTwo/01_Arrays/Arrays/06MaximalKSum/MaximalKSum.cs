using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

namespace _06MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            //There are two solutions of this problem. See the comments below.

            Console.WriteLine("Enter the value of N:");
            int sizeOfArray = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of K:");
            int k = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = new int[sizeOfArray];


            //Initialize the array.
            for (int i = 0; i < sizeOfArray; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            //If the K sum is the sum of the K biggest numbers use this:

            //Sort the array.
            Array.Sort(arrayOfNumbers);

            //Make array for the biggest numbers.
            int[] intResult = new int[k];


            for (int i = sizeOfArray - k, j = 0; i < sizeOfArray; i++, j++)
            {
                intResult[j] = arrayOfNumbers[i];
            }

            string result = string.Join(", ", intResult);
            Console.WriteLine(result);

            //If the K sum is the biggest sum of consecutive numbers uncomment this code:
            /*
            int currentSum = 0;
            int maxSum = 0;
            int indexOfMaxSum = 0;

            //Find the max K sum.
            for (int i = 0; i < sizeOfArray - k + 1; i++)
            {
                currentSum = 0;

                for (int j = i; j < i + k; j++)
                {
                    currentSum += arrayOfNumbers[j];
                }

                if (i == 0)
                {
                    maxSum = currentSum;
                }

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    indexOfMaxSum = i;
                }
            }

            Console.WriteLine("The Maximal K sum is: {0} and the sequence is:", maxSum);
            for (int i = indexOfMaxSum; i < indexOfMaxSum + k; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();
            */
        }
    }
}

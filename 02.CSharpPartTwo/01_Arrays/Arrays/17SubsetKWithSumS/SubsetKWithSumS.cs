using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 17.* Subset K with sum S

Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

namespace _17SubsetKWithSumS
{
    class SubsetKWithSumS
    {
        static void Main(string[] args)
        {
            //If you want to enter your own array use this the row below.
            //Console.Write("Enter the sum you are looking for: ");
            //int s = int.Parse(Console.ReadLine());
            //Console.Write("Enter the subset size: ");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int[] array = InitArray();

            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int s = 14;
            int k = 4;
            int sizeOfArray = array.Length;
            int allCombinationsCount = (int)Math.Pow(2, sizeOfArray);
            bool hasSum = false;

            string[] allCombinations = new string[allCombinationsCount];

            MakeAllCombinations(sizeOfArray, allCombinationsCount, allCombinations);

            hasSum = CheckSum(array, sizeOfArray, allCombinations, allCombinationsCount, s, k);

            if (hasSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static int FindCountOfSubset(string subset)
        {
            //Find the count of the current subset combination.

            int n = 0;
            int sizeOfSubset = subset.Length;

            for (int i = 0; i < sizeOfSubset; i++)
            {
                if (subset[i] == '1')
                {
                    n++;
                }
            }

            return n;
        }

        static bool CheckSum(int[] array, int sizeOfArray, string[] allCombinations, int allCombinationsCount, int sum, int subsetSize)
        {
            //Checks all the combinations for the wanted sum. If the current bit of the combination is 1 then add the number of the int array in this position to the current sum.

            int currentSum = 0;
            int currentSubsetSize = 0;

            for (int i = 0; i < allCombinationsCount; i++)
            {
                currentSum = 0;
                currentSubsetSize = FindCountOfSubset(allCombinations[i]);

                //If the count of the combination is not equal to the given subset count don't do anything.
                if (currentSubsetSize != subsetSize)
                {
                    continue;
                }
                for (int j = 0; j < sizeOfArray; j++)
                {
                    if (allCombinations[i][j] == '1')
                    {
                        currentSum += array[j];
                        if (currentSum == sum)
                        {
                            return true;
                        }
                        else if (currentSum > sum)
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }

        static void MakeAllCombinations(int sizeOfArray, int allCombinationsCount, string[] allCombinations)
        {
            //Make string array with all combinations of the array numbers represented by binary numbers.
            for (int i = 0; i < allCombinationsCount; i++)
            {
                allCombinations[i] = Convert.ToString(i, 2).PadLeft(sizeOfArray, '0');
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

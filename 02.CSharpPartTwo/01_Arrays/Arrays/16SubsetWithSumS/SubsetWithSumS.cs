using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 16.* Subset with sum S

We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */

namespace _16SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main(string[] args)
        {
            //If you want to enter your own array use this the row below.
            //Console.Write("Enter the sum you are looking for: ");
            //int s = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int[] array = InitArray();

            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int s = 14;
            int sizeOfArray = array.Length;
            int allCombinationsCount = (int)Math.Pow(2, sizeOfArray);
            bool hasSum = false;

            string[] allCombinations = new string[allCombinationsCount];

            MakeAllCombinations(sizeOfArray, allCombinationsCount, allCombinations);

            hasSum = CheckSum(array, sizeOfArray, allCombinations, allCombinationsCount, s);

            if (hasSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool CheckSum(int[] array, int sizeOfArray, string[] allCombinations, int allCombinationsCount, int sum)
        {
            //Checks all the combinations for the wanted sum. If the current bit of the combination is 1 then add the number of the int array in this position to the current sum.

            int currentSum = 0;
            for (int i = 0; i < allCombinationsCount; i++)
            {
                currentSum = 0;
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
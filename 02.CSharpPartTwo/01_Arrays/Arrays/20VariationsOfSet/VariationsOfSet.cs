using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 20.* Variations of set

Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
 */

namespace _20VariationsOfSet
{
    class VariationsOfSet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of K:");
            int k = int.Parse(Console.ReadLine());

            int[] array = InitArray(n);
            int sizeOfArray = n;
            int allCombinatiosCount = (int)Math.Pow(2, n);
            string[] allCombinations = new string[allCombinatiosCount];

            List<string> neededCombinations = new List<string>();

            //FindVariations(k, array, sizeOfArray);

            MakeAllCombinations(sizeOfArray, allCombinatiosCount, allCombinations);

            neededCombinations = MakeNeededCombinations(array, allCombinations, k);

            MakeVariations(array, sizeOfArray, neededCombinations, k);

        }

        static List<string> MakeNeededCombinations(int[] array, string[] allCombinations, int k)
        {
            List<string> result = new List<string>();

            bool hasKLength = false;

            string currentCombination = "";

            for (int i = 0; i < allCombinations.GetLength(0); i++)
            {
                hasKLength = CheckCombinationLength(allCombinations[i], k);

                if (hasKLength)
                {
                    for (int j = 0; j < allCombinations[i].Length; j++)
                    {
                        if (allCombinations[i][j] == '1')
                        {
                            currentCombination += array[j];
                            currentCombination += ' ';
                        }
                    }
                    result.Add(currentCombination);
                }
                currentCombination = "";
            }

            result.Reverse();

            return result;
        }

        static void MakeAllCombinations(int sizeOfArray, int allCombinationsCount, string[] allCombinations)
        {
            //Make string array with all combinations of the array numbers represented by binary numbers.

            for (int i = 0; i < allCombinationsCount; i++)
            {
                allCombinations[i] = Convert.ToString(i, 2).PadLeft(sizeOfArray, '0');
            }
        }

        static bool CheckCombinationLength(string currentCombination, int k)
        {
            int counter = 0;

            for (int j = 0; j < currentCombination.Length; j++)
            {
                if (currentCombination[j] == '1')
                {
                    counter++;
                }
            }

            if (counter == k - 1)
            {
                return true;
            }
            return false;
        }

        static void MakeVariations(int[] array, int sizeOfArray, List<string> neededCombinations, int k)
        {
            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int j = 0; j < neededCombinations.Count; j++)
                {
                    Console.WriteLine("{0} {1} ", array[i], neededCombinations[j]);
                }
            }
        }

        static void PrintArray(int[] array)
        {
            //Prints an int array.

            string result = string.Join(", ", array);

            Console.WriteLine("\n{0}\n", result);
        }
        static void PrintArray(string[] array)
        {
            //Prints an int array.

            string result = string.Join(", ", array);

            Console.WriteLine("\n{0}\n", result);
        }
        static void PrintArray(List<string> array)
        {
            //Prints an int array.

            string result = string.Join(", ", array);

            Console.WriteLine("\n{0}\n", result);
        }

        //private static void FindVariations(int k, int[] array, int sizeOfArray)
        //{
        //    for (int i = 0; i < sizeOfArray; i++)
        //    {
        //        Console.Write("{0} ", array[i]);
        //        for (int l = 0; l < k - 1; l++)
        //        {
        //            for (int j = 0; j < sizeOfArray; j++)
        //            {
        //                Console.Write("{0} ", array[j]);
        //                if (j == k)
        //                {
        //                    Console.WriteLine();
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //Unsuccessful try with recursion.
        /*
        static void FindVariations(int[] array, int start, int end, int k)
        {
            int temp = 0;
            if (start == end)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    temp = array[start];
                    array[start] = array[i];
                    array[i] = temp;

                    FindVariations(array, start + 1, end, k);

                    temp = array[start];
                    array[start] = array[i];
                    array[i] = temp;
                }
            }
        }*/

        static int[] InitArray(int n)
        {
            //Initializes an int array.

            int sizeOfArray = n;

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = i + 1;
            }
            Console.WriteLine();
            return array;
        }
    }
}

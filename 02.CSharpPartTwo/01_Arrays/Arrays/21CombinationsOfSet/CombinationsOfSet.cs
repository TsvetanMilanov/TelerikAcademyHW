using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 21.* Combinations of set

Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
 */

namespace _21CombinationsOfSet
{
    class CombinationsOfSet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of K:");
            int k = int.Parse(Console.ReadLine());

            //Initializing array with N values.
            int[] array = InitArray(n);

            int sizeOfArray = n;

            int allCombinatiosCount = (int)Math.Pow(2, n);

            string[] allCombinations = new string[allCombinatiosCount];

            List<string> neededCombinations = new List<string>();

            MakeAllCombinations(sizeOfArray, allCombinatiosCount, allCombinations);

            neededCombinations = MakeNeededCombinations(array, allCombinations, k);

            MakeCombinationsOfSet(array, sizeOfArray, neededCombinations);
        }

        static List<string> MakeNeededCombinations(int[] array, string[] allCombinations, int k)
        {
            //Make list of combinations of combinations with k-1 lenght.

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
            //Check if the combination is with length == k - 1.

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

        static void MakeCombinationsOfSet(int[] array, int sizeOfArray, List<string> neededCombinations)
        {
            //Make all combinations.

            string result = "";
            List<string> results = new List<string>();

            for (int i = 0; i < sizeOfArray; i++)
            {

                for (int j = 0; j < neededCombinations.Count; j++)
                {
                    if (neededCombinations[j].Contains(Convert.ToString(array[i])))
                    {
                        continue;
                    }

                    result += array[i];
                    result += ' ';
                    result += neededCombinations[j];

                    result = result.Remove(result.Length - 1);

                    results.Add(result);
                    result = string.Empty;
                }
            }

            string check;

            for (int i = 0; i < results.Count; i++)
            {
                check = (string)results[i].Clone();

                check = new string(check.ToCharArray().Reverse().ToArray());

                if (results.Contains(check))
                {
                    results.Remove(check);
                }
            }

            PrintArray(results);
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

            string result = string.Join("\n", array);

            Console.WriteLine("\n{0}\n", result);
        }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            //For console input:
            //int[] array = InitArray();

            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int sizeOfArray = array.Length;
            int allCombinationsCount = (int)Math.Pow(2, sizeOfArray);

            string[] allCombinations = new string[allCombinationsCount];

            //Make all combinations of removed elements in the array.
            MakeAllCombinations(sizeOfArray, allCombinationsCount, allCombinations);

            Console.WriteLine("The initial array is:");
            PrintArray(array);

            List<List<int>> sortedArrays = new List<List<int>>();

            //Make list of lists with all the combinations of removed items.
            for (int i = 0; i < allCombinationsCount; i++)
            {
                sortedArrays.Add(new List<int>());
                for (int j = 0; j < sizeOfArray; j++)
                {
                    if (allCombinations[i][j] == '1')
                    {
                        sortedArrays[i].Add(array[j]);
                    }
                }
            }
            sortedArrays.TrimExcess();

            int bestIndex = 0;
            int bestSize = 0;
            bool flag = false;

            for (int i = 0; i < sortedArrays.Count; i++)
            {
                if (IsSorted(sortedArrays[i]))
                {
                    if (!flag)
                    {
                        bestIndex = i;
                        bestSize = sortedArrays[i].Count;
                        flag = true;
                    }
                    else
                    {
                        if (sortedArrays[i].Count > bestSize)
                        {
                            bestIndex = i;
                            bestSize = sortedArrays[i].Count;
                        }
                    }
                }
            }

            Console.WriteLine("The result is:");
            Console.WriteLine(string.Join(", ", sortedArrays[bestIndex]));
            Console.WriteLine();
        }


        static bool IsSorted(List<int> list)
        {
            //Check if the list is sorted.

            int[] tempArray = new int[list.Count];

            list.CopyTo(tempArray);

            List<int> sortedList = new List<int>();

            sortedList = tempArray.ToList();

            sortedList.Sort();

            for (int i = 0; i < sortedList.Count; i++)
            {
                if (list[i] != sortedList[i])
                {
                    return false;
                }
            }

            return true;
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

        static void PrintArray(int[] array)
        {
            //Prints an int array.

            string result = string.Join(", ", array);

            Console.WriteLine("\n{0}\n", result);
        }

        static void MakeAllCombinations(int sizeOfArray, int allCombinationsCount, string[] allCombinations)
        {
            //Make string array with all combinations of the array numbers represented by binary numbers.
            for (int i = 0; i < allCombinationsCount; i++)
            {
                allCombinations[i] = Convert.ToString(i, 2).PadLeft(sizeOfArray, '0');
            }
        }

    }
}

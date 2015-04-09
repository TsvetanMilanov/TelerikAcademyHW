using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */

namespace _05SortByStringLength
{
    class SoortByStringLength
    {
        static void Main(string[] args)
        {
            //Console input.
            //string[] array = InitArray();

            string[] array = { "aerwegbcdef", "a", "ergergabcdefg", "fsdgeab", "ee", "egc", "gabcd", "abcdefg" };

            Array.Sort(array, new CompareString());

            string result = string.Join("\n", array);
            Console.WriteLine(result);
        }

        private class CompareString : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }

        static string[] InitArray()
        {
            //Initializes an int array.

            Console.Write("Enter the size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            string[] array = new string[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Console.ReadLine();
            }

            Console.WriteLine();

            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 19.* Permutations of set

Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
 */

namespace _19PermutationsOfSet
{
    class PermutationsOfSet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int n = int.Parse(Console.ReadLine());

            int[] array = InitArray(n);
            int sizeOfArray = n;
            int permutationsCount = FindFactoriel(n);

            FindPermutation(array, 0, sizeOfArray);
        }

        static void FindPermutation(int[] array, int start, int end)
        {
            int temp = 0;
            if (start == end)
            {
                for (int i = 0; i < end; i++)
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

                    FindPermutation(array, start + 1, end);

                    temp = array[start];
                    array[start] = array[i];
                    array[i] = temp;
                }
            }
        }

        static int FindFactoriel(int n)
        {
            //Find n!
            int factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
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

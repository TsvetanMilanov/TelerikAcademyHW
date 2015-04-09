using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

namespace _02MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            //For manual input:
            //int[,] matrix = ManualInitMatrix();

            int[,] matrix = AutoInitMatrix();

            long maxSum = long.MinValue;
            long currentSum = 0;

            int sizeOfCube = 3;

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n < sizeOfCube || m < sizeOfCube)
            {
                Console.WriteLine("The matrix is not big enough for the wanted sum size.");
                return;
            }

            PrintMatrix(matrix);

            int maxI = 0;
            int maxJ = 0;

            //Find the maximal sum.
            for (int i = 0; i <= n - sizeOfCube; i++)
            {
                for (int j = 0; j <= n - sizeOfCube; j++)
                {
                    currentSum = FindCurrentSum(matrix, sizeOfCube, i, j);
                    if (currentSum > maxSum)
                    {
                        maxI = i;
                        maxJ = j;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine("The maximal sum with size 3x3 in the matix is: {0}\n", maxSum);


            //Print the cube with maxima sum.
            for (int i = 0; i < sizeOfCube; i++)
            {
                for (int j = 0; j < sizeOfCube; j++)
                {
                    Console.Write("{0,4}", matrix[maxI + i, maxJ + j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static long FindCurrentSum(int[,] matrix, int sizeOfCube, int currentRow, int currentCol)
        {
            //Find the wanted sum of the elements starting form the position currentRow, currentCol.
            long currentSum = 0;
            for (int i = 0; i < sizeOfCube; i++)
            {
                for (int j = 0; j < sizeOfCube; j++)
                {
                    currentSum += matrix[currentRow + i, currentCol + j];
                }
            }
            return currentSum;
        }

        static int[,] ManualInitMatrix()
        {
            Console.WriteLine("Enter the size N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size M:");
            int m = int.Parse(Console.ReadLine());

            int[,] result = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("matrix[{0}, {1}] = ", i, j);
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return result;
        }

        static int[,] AutoInitMatrix()
        {
            int n = 4;
            int m = 4;
            int[,] result = new int[n, m];
            int currentNumber = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = currentNumber;
                    currentNumber++;
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("The matrix is:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
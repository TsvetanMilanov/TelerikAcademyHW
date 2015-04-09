using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 */

namespace _05MaximalAreaSum
{
    class MaximalAreaSum
    {
        static int matrixSize = 0;

        static void Main(string[] args)
        {
            List<string> matrixAsList = new List<string>();

            string currentLine = string.Empty;

            using (StreamReader inputReader = new StreamReader("input.txt"))
            {
                matrixSize = Convert.ToInt32(inputReader.ReadLine());

                while ((currentLine = inputReader.ReadLine()) != null)
                {
                    matrixAsList.Add(currentLine);
                }
            }

            long maxSum = long.MinValue;
            long currentSum = 0;

            int sizeOfCube = 2;

            int[,] matrix = CreateMatrixFromList(matrixAsList);

            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i <= matrixSize - sizeOfCube; i++)
            {
                for (int j = 0; j <= matrixSize - sizeOfCube; j++)
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

            PrintMatrix(matrix);

            Console.WriteLine("The maximal sum with size 2x2 in the matix is: {0}\n", maxSum);

        }

        private static int[,] CreateMatrixFromList(List<string> matrixAsList)
        {
            int[,] result = new int[matrixSize, matrixSize];

            char[] separators = { ' ' };
            for (int i = 0; i < matrixSize; i++)
            {
                string[] currentLine = matrixAsList[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrixSize; j++)
                {
                    result[i, j] = Convert.ToInt32(currentLine[j]);
                }
            }

            return result;
        }

        static long FindCurrentSum(int[,] matrix, int sizeOfCube, int currentRow, int currentCol)
        {
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

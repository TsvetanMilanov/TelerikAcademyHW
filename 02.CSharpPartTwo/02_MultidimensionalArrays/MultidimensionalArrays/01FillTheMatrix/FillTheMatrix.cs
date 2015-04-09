using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
 */

namespace _01FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size N:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            int[,] matrixC = new int[n, n];
            int[,] matrixD = new int[n, n];

            FillMatrixA(matrixA, n);

            PrintMatrix(matrixA, "A");

            FillMatrixB(matrixB, n);

            PrintMatrix(matrixB, "B");

            FillMatrixC(matrixC, n);

            PrintMatrix(matrixC, "C");

            FillMatrixD(matrixD, n);

            PrintMatrix(matrixD, "D");


        }



        static void FillMatrixA(int[,] matrixA, int n)
        {
            int currentNumber = 1;

            int leftIndex = 0;

            //Fill each column with currentNumber and increasing the start left column.
            do
            {
                for (int i = 0; i < n; i++)
                {
                    matrixA[i, leftIndex] = currentNumber;
                    currentNumber++;
                }
                leftIndex++;
            } while (currentNumber < n * n);

            #region Fill with formula.
            //Fill with fiormula.
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        matrixA[i, j] = i + n * j + 1;
            //    }
            //}
            #endregion
        }

        static void FillMatrixB(int[,] matrixB, int n)
        {
            int currentNumber = 1;
            int leftIndex = 0;
            int heigthIndex = n - 1;

            //Fill each column with numbers and switching between starting from the top or from the bottom.
            do
            {
               //Start from the bottom.
                if (heigthIndex == 0)
                {
                    for (int i = n - 1; i >= heigthIndex; i--)
                    {
                        matrixB[i, leftIndex] = currentNumber;
                        currentNumber++;
                    }
                    leftIndex++;
                    heigthIndex = n - 1;
                }
                else
                {
                    //Start from the top.
                    for (int i = 0; i <= heigthIndex; i++)
                    {
                        matrixB[i, leftIndex] = currentNumber;
                        currentNumber++;
                    }
                    leftIndex++;
                    heigthIndex = 0;
                }

            } while (currentNumber < n * n);

        }

        static void FillMatrixC(int[,] matrixC, int n)
        {
            int currentNumber = 1;
            int currentPositionRow = 0;
            int currentPositionCol = 0;
            int currentCount = 1;
            int heigthIndex = 0;
            int counter = 1;

            do
            {
                //Fill the left side under the diagonal.
                for (int i = n - 1; i >= heigthIndex; i--)
                {
                    matrixC[i, 0] = currentNumber;
                    currentNumber++;
                    currentPositionRow = i;
                    currentPositionCol = 0;
                    counter = 1;
                    while (counter < currentCount)
                    {
                        currentPositionRow++;
                        currentPositionCol++;
                        matrixC[currentPositionRow, currentPositionCol] = currentNumber;
                        currentNumber++;
                        counter++;
                    }
                    currentCount++;
                }

                counter = n - 1;
                currentCount = n - 1;

                //Fill the right side over the diagonal.
                for (int i = 1; i <= n - 1; i++)
                {
                    currentPositionRow = 0;
                    currentPositionCol = i;

                    matrixC[currentPositionRow, currentPositionCol] = currentNumber;
                    currentNumber++;

                    for (int j = 1; j < counter; j++)
                    {
                        currentPositionRow++;
                        currentPositionCol++;

                        matrixC[currentPositionRow, currentPositionCol] = currentNumber;
                        currentNumber++;
                    }
                    counter--;

                }

            } while (currentNumber < n * n);

        }

        static void FillMatrixD(int[,] matrixD, int n)
        {
            int currentNumber = 1;

            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;


            //Fill the matrix to the border (top, left, right or bottom) and when reaching top, left, right or bottom border increase or decreas it.
            do
            {
                for (int i = top; i <= bottom; i++)
                {
                    matrixD[i, left] = currentNumber;
                    currentNumber++;
                }
                left++;

                for (int i = left; i <= right; i++)
                {
                    matrixD[bottom, i] = currentNumber;
                    currentNumber++;
                }

                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    matrixD[i, right] = currentNumber;
                    currentNumber++;
                }

                right--;

                for (int i = right; i >= left; i--)
                {
                    matrixD[top, i] = currentNumber;
                    currentNumber++;
                }
                top++;


            } while (currentNumber < n * n);
        }

        static void PrintMatrix(int[,] matrixA, string name)
        {
            Console.WriteLine("\nThe matrix {0} is:\n", name);

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrixA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
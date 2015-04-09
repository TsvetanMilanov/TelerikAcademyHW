using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */

namespace _03SequenceNMatrix
{
    class SequenceNMatrix
    {
        static void Main(string[] args)
        {
            //For manual input:
            //string[,] matrix = ManualInitMatrix();

            string[,] matrix = AutoInitMatrix();

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int longestSequence = int.MinValue;
            int currentSequenceLength = 0;

            string sequenceWord = "";

            PrintMatrix(matrix);

            //Checks the length of the sequence for each element in the matrix and finds the longest one.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    currentSequenceLength = FindSequence(matrix, n, m, i, j);

                    if (currentSequenceLength > longestSequence)
                    {
                        longestSequence = currentSequenceLength;
                        sequenceWord = "";
                        sequenceWord = (string)matrix[i, j].Clone();
                    }
                }
            }

            string[] sequence = new string[longestSequence];

            for (int i = 0; i < longestSequence; i++)
            {
                sequence[i] += sequenceWord;
            }

            Console.WriteLine("The longest sequence length is: {0} and is: {1}\n", longestSequence, string.Join(", ", sequence));
        }

        static int FindSequence(string[,] matrix, int n, int m, int currentRow, int currentCol)
        {
            //Calculates the length of the current elements sequence in all directions and finds the biggest one.

            int rowSum = checkRow(matrix, n, m, currentRow, currentCol);
            int colSum = checkCol(matrix, n, m, currentRow, currentCol);
            int diagonalSum = checkDiagonal(matrix, n, m, currentRow, currentCol);

            if (rowSum >= Math.Max(colSum, diagonalSum))
            {
                return rowSum;
            }

            if (colSum >= Math.Max(rowSum, diagonalSum))
            {
                return colSum;
            }

            if (diagonalSum >= Math.Max(colSum, rowSum))
            {
                return diagonalSum;
            }

            return 0;
        }

        private static int checkDiagonal(string[,] matrix, int n, int m, int currentRow, int currentCol)
        {
            //Calculates the length of the sequence in the current diagonal from the current position.

            int diagSum = 0;
            double diagonalLength = Math.Sqrt((n * n) + (m * m));

            string template = (string)matrix[currentRow, currentCol].Clone();

            for (int i = currentRow; i < diagonalLength; i++)
            {
                if (currentRow + i >= n || currentCol + i >= m)
                {
                    break;
                }
                if (matrix[currentRow + i, currentCol + i] != template)
                {
                    break;
                }
                else
                {
                    diagSum++;
                }
            }
            return diagSum;
        }

        private static int checkCol(string[,] matrix, int n, int m, int currentRow, int currentCol)
        {
            //Calculates the length of the sequence in the current col from the current position.

            int colSum = 0;

            string template = (string)matrix[currentRow, currentCol].Clone();

            for (int i = currentRow; i < m; i++)
            {
                if (currentCol + i >= m)
                {
                    break;
                }
                if (matrix[currentRow, currentCol + i] != template)
                {
                    break;
                }
                else
                {
                    colSum++;
                }
            }
            return colSum;
        }

        static int checkRow(string[,] matrix, int n, int m, int currentRow, int currentCol)
        {
            //Calculates the length of the sequence in the current row from the current position.

            int rowSum = 0;

            string template = (string)matrix[currentRow, currentCol].Clone();

            for (int i = currentRow; i < n; i++)
            {
                if (currentRow + i >= n)
                {
                    break;
                }
                if (matrix[currentRow + i, currentCol] != template)
                {
                    break;
                }
                else
                {
                    rowSum++;
                }
            }
            return rowSum;
        }

        static string[,] ManualInitMatrix()
        {
            Console.WriteLine("Enter the size N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size M:");
            int m = int.Parse(Console.ReadLine());

            string[,] result = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("matrix[{0}, {1}] = ", i, j);
                    result[i, j] = Console.ReadLine();
                }
            }

            return result;
        }

        static string[,] AutoInitMatrix()
        {

            string[,] result = new string[,] {{"ha", "fifi", "ho", "hi"},
                                               {"fo", "ha", "hi", "xx"},
                                               {"xxx", "fo", "ha", "xx"}};

            return result;
        }

        static void PrintMatrix(string[,] matrix)
        {
            Console.WriteLine("The matrix is:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

namespace Lover
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class LoverOfTwo
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int movesCount = int.Parse(Console.ReadLine());
            int[] directionsAndMoves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int coeffficient = Math.Max(rows, cols);
            BigInteger[,] matrix = new BigInteger[rows, cols];
            bool[,] visitedCells = new bool[rows, cols];

            matrix = MakeMatrix(matrix, rows, cols);

            int[][] cells = CalculateCellsCoordinates(directionsAndMoves, coeffficient);

            BigInteger sum = FindSum(matrix, visitedCells, rows, cols, cells);
            Console.WriteLine(sum);
        }

        private static BigInteger FindSum(BigInteger[,] matrix, bool[,] visitedCells, int rows, int cols, int[][] cells)
        {
            BigInteger sum = 0;

            int[] currentPosition = { rows - 1, 0 };

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                int[] targetCell = cells[i];
                int rowsDirection = targetCell[0] - currentPosition[0];
                int colsDirection = targetCell[1] - currentPosition[1];
                int[] direction = { rowsDirection, colsDirection };

                if (direction[0] < 0)
                {
                    /// Move up
                    sum += SumValuesUpFromPosition(matrix, visitedCells, currentPosition, direction);
                }

                if (direction[0] > 0)
                {
                    /// Move down
                    sum += SumValuesDownFromPosition(matrix, visitedCells, currentPosition, direction);
                }

                if (direction[1] < 0)
                {
                    /// Move left.
                    sum += SumValuesLeftFromPosition(matrix, visitedCells, currentPosition, direction);
                }

                if (direction[1] > 0)
                {
                    /// Move right.
                    sum += SumValuesRightFromPosition(matrix, visitedCells, currentPosition, direction);
                }
            }

            return sum;
        }

        private static BigInteger SumValuesRightFromPosition(BigInteger[,] matrix, bool[,] visitedCells, int[] currentPosition, int[] direction)
        {
            BigInteger sum = 0;
            int countOfMoves = direction[1];

            while (countOfMoves != -1)
            {
                if (visitedCells[currentPosition[0], currentPosition[1]] == false)
                {
                    sum += matrix[currentPosition[0], currentPosition[1]];
                    visitedCells[currentPosition[0], currentPosition[1]] = true;
                }

                countOfMoves--;
                currentPosition[1] += 1;
            }

            currentPosition[1] -= 1;
            return sum;
        }

        private static BigInteger SumValuesLeftFromPosition(BigInteger[,] matrix, bool[,] visitedCells, int[] currentPosition, int[] direction)
        {
            BigInteger sum = 0;
            int countOfMoves = direction[1];

            while (countOfMoves != 1)
            {
                if (visitedCells[currentPosition[0], currentPosition[1]] == false)
                {
                    sum += matrix[currentPosition[0], currentPosition[1]];
                    visitedCells[currentPosition[0], currentPosition[1]] = true;
                }

                countOfMoves++;
                currentPosition[1] -= 1;
            }

            currentPosition[1] += 1;
            return sum;
        }

        private static BigInteger SumValuesDownFromPosition(BigInteger[,] matrix, bool[,] visitedCells, int[] currentPosition, int[] direction)
        {
            BigInteger sum = 0;
            int countOfMoves = direction[0];

            while (countOfMoves != -1)
            {
                if (visitedCells[currentPosition[0], currentPosition[1]] == false)
                {
                    sum += matrix[currentPosition[0], currentPosition[1]];
                    visitedCells[currentPosition[0], currentPosition[1]] = true;
                }

                countOfMoves--;
                currentPosition[0] += 1;
            }

            currentPosition[0] -= 1;
            return sum;
        }

        private static BigInteger SumValuesUpFromPosition(BigInteger[,] matrix, bool[,] visitedCells, int[] currentPosition, int[] direction)
        {
            BigInteger sum = 0;
            int countOfMoves = direction[0];

            while (countOfMoves != 1)
            {
                int currentPositionRow = currentPosition[0];
                int currentPositionCol = currentPosition[1];
                if (visitedCells[currentPositionRow, currentPositionCol] == false)
                {
                    sum += matrix[currentPositionRow, currentPositionCol];
                    visitedCells[currentPositionRow, currentPositionCol] = true;
                }

                countOfMoves++;
                currentPosition[0] -= 1;
            }

            currentPosition[0] += 1;
            return sum;
        }

        private static int[][] CalculateCellsCoordinates(int[] directionsAndMoves, int coefficient)
        {
            int directionsAndMovesLength = directionsAndMoves.GetLength(0);

            int[][] result = new int[directionsAndMovesLength][];

            for (int i = 0; i < directionsAndMovesLength; i++)
            {
                result[i] = new int[2];
                result[i][0] = directionsAndMoves[i] / coefficient;
                result[i][1] = directionsAndMoves[i] % coefficient;
            }

            return result;
        }

        private static BigInteger[,] MakeMatrix(BigInteger[,] matrix, int rows, int cols)
        {
            BigInteger[,] result = new BigInteger[rows, cols];

            int currentRowPower = 0;
            int currentPower = currentRowPower;
            int indexOfPositionToFill = 0;
            BigInteger currentNumber = Power(2, currentRowPower);

            do
            {
                for (int i = rows - 1; i >= 0; i--)
                {
                    result[i, indexOfPositionToFill] = currentNumber;
                    currentPower++;
                    currentNumber = Power(2, currentPower);
                }

                indexOfPositionToFill++;
                currentRowPower++;
                currentPower = currentRowPower;
                currentNumber = Power(2, currentPower);
            } while (indexOfPositionToFill < cols);

            return result;
        }

        private static BigInteger Power(int systemBase, int currentPow)
        {
            BigInteger result = 1;

            for (int i = 0; i < currentPow; i++)
            {
                result *= systemBase;
            }

            return result;
        }

        private static void PrintMatrix<T>(T[,] matrinx)
        {
            for (int i = 0; i < matrinx.GetLength(0); i++)
            {
                for (int j = 0; j < matrinx.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrinx[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
namespace EightQueenProblem
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static int queensCount;
        private static int[,] board;
        private static int n;
        private static int solution = 0;

        public static void Main()
        {
            Console.Write("Enter the size of the board: ");
            n = int.Parse(Console.ReadLine());
            queensCount = n;

            board = new int[n, n];
            
            FindCombinationOfPositions(0);

            Console.WriteLine("Total combinations: {0}", solution);
        }

        private static void ClearBoard()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = 1;
                }
            }
        }

        private static void FindCombinationOfPositions(int startRow)
        {
            if (startRow == n)
            {
                solution += 1;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (board[startRow, i] == 0)
                {
                    board[startRow, i] += 1;
                    PlaceQueen(startRow, i);

                    FindCombinationOfPositions(startRow + 1);

                    board[startRow, i] -= 1;
                    RemoveQueen(startRow, i);
                }
            }
        }

        private static void RemoveQueen(int row, int col)
        {
            for (int i = row; i < n; i++)
            {
                board[i, col] -= 1;

                if (col + (i - row) < n)
                {
                    board[i, col + (i - row)] -= 1;
                }

                if (col - (i - row) >= 0)
                {
                    board[i, col - (i - row)] -= 1;
                }
            }
        }

        private static void PlaceQueen(int row, int col)
        {
            for (int i = row; i < n; i++)
            {
                board[i, col] += 1;

                if (col + (i - row) < n)
                {
                    board[i, col + (i - row)] += 1;
                }

                if (col - (i - row) >= 0)
                {
                    board[i, col - (i - row)] += 1;
                }
            }
        }

        private static int[,] CopyBoard(int[,] board)
        {
            int[,] result = new int[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    result[i, j] = board[i, j];
                }
            }

            return result;
        }

        private static bool CheckIfPositionIsValid(int row, int col)
        {
            int n = board.GetLength(0);

            bool isInRangeOfMatrix = row < n && row >= 0 &&
                                    col < n && col >= 0;

            if (!isInRangeOfMatrix)
            {
                return false;
            }

            bool isValidVerticaly = CheckVerticaly(col);

            if (!isValidVerticaly)
            {
                return false;
            }

            bool isValidHorizontaly = CheckHorizontaly(row);

            if (!isValidHorizontaly)
            {
                return false;
            }

            bool isValidDiagonaly = CheckDiagonaly(row, col);

            if (!isValidDiagonaly)
            {
                return false;
            }

            return true;
        }

        private static bool CheckDiagonaly(int row, int col)
        {
            int n = board.GetLength(0);

            int currentRow = row;
            int currentCol = col;

            bool isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // up right
            while (isInRangeOfMatrix)
            {
                if (board[currentRow, currentCol] == 0)
                {
                    return false;
                }

                currentCol += 1;
                currentRow -= 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // down right
            while (isInRangeOfMatrix)
            {
                if (board[currentRow, currentCol] == 0)
                {
                    return false;
                }

                currentCol += 1;
                currentRow += 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // up left
            while (isInRangeOfMatrix)
            {
                if (board[currentRow, currentCol] == 0)
                {
                    return false;
                }

                currentCol -= 1;
                currentRow -= 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // down left
            while (isInRangeOfMatrix)
            {
                if (board[currentRow, currentCol] == 0)
                {
                    return false;
                }

                currentCol -= 1;
                currentRow += 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            return true;
        }

        private static bool CheckHorizontaly(int row)
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[row, i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckVerticaly(int col)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, col] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void MarkCells(int row, int col, int isAvailable)
        {
            MarkCellsVerticaly(col, isAvailable);
            MarkCellsHorizontaly(row, isAvailable);
            MarkCellsDiagonaly(row, col, isAvailable);
        }

        private static void MarkCellsDiagonaly(int row, int col, int isAvailable)
        {
            int n = board.GetLength(0);

            int currentRow = row;
            int currentCol = col;

            bool isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;

            // up right
            while (isInRangeOfMatrix)
            {
                board[currentRow, currentCol] = isAvailable;

                currentCol += 1;
                currentRow -= 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // down right
            while (isInRangeOfMatrix)
            {
                board[currentRow, currentCol] = isAvailable;

                currentCol += 1;
                currentRow += 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // up left
            while (isInRangeOfMatrix)
            {
                board[currentRow, currentCol] = isAvailable;

                currentCol -= 1;
                currentRow -= 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }

            currentRow = row;
            currentCol = col;
            isInRangeOfMatrix = true;
            // down left
            while (isInRangeOfMatrix)
            {
                board[currentRow, currentCol] = isAvailable;

                currentCol -= 1;
                currentRow += 1;
                isInRangeOfMatrix = currentCol < n && currentCol >= 0 &&
                                    currentRow < n && currentRow >= 0;
            }
        }

        private static void MarkCellsHorizontaly(int row, int isAvailable)
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                board[row, i] = isAvailable;
            }
        }

        private static void MarkCellsVerticaly(int col, int isAvailable)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[i, col] = isAvailable;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

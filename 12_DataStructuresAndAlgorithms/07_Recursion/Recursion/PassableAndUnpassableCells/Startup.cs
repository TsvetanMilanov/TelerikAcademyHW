namespace PassableAndUnpassableCells
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static List<Queue<MatrixCellCoordinates>> allPaths = new List<Queue<MatrixCellCoordinates>>();

        public static void Main()
        {
            string[,] matrix = new string[,]
            {
                { "0", "0", "0", "x", "0", "x" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "0", "x", "0", "x", "0" },
                { "0", "x", "0", "0", "0", "0" },
                { "0", "0", "0", "x", "x", "0" },
                { "0", "0", "0", "x", "0", "x" },
            };

            string[,] result = matrix;
            int startPointRow = 2;
            int startPointCol = 1;
            
            matrix[startPointRow, startPointCol] = "*";

            result = MoveInDirection(result, 2, 1, new Queue<MatrixCellCoordinates>(), Directions.None);

            Console.WriteLine("Marked cells (+ : passable, - : unpassable):");

            Console.WriteLine();
            matrix[startPointRow, startPointCol] = "*";
            MarkPassableCells(matrix);
            MarkUnpassableCells(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
        }

        private static void MarkUnpassableCells(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "0")
                    {
                        matrix[i, j] = "-";
                    }
                }
            }
        }

        private static void MarkPassableCells(string[,] matrix)
        {
            foreach (var path in allPaths)
            {
                foreach (var coordinates in path)
                {
                    matrix[coordinates.Row, coordinates.Col] = "+";
                }
            }
        }

        private static string[,] FillPath(string[,] matrix, Queue<MatrixCellCoordinates> path)
        {
            int stepCount = 1;
            string[,] matrixCopy = CopyMatrix(matrix);

            foreach (var coordinates in path)
            {
                matrixCopy[coordinates.Row, coordinates.Col] = stepCount.ToString();
                stepCount++;
            }

            return matrixCopy;
        }

        private static string[,] CopyMatrix(string[,] matrix)
        {
            string[,] result = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            return result;
        }

        private static string[,] MoveInDirection(string[,] matrix, int rowPosition, int colPosition, Queue<MatrixCellCoordinates> currentPath, Directions lastDirection)
        {
            bool positionIsInRangeOfTheMatrix =
                   ((colPosition >= 0 && colPosition < matrix.GetLength(0)) &&
                   (rowPosition >= 0 && rowPosition < matrix.GetLength(1)));

            if (!positionIsInRangeOfTheMatrix)
            {
                allPaths.Add(currentPath);

                return matrix;
            }

            string currentPosition = matrix[rowPosition, colPosition];

            bool cellIsNotAvailable = currentPosition == "x";

            if (cellIsNotAvailable)
            {
                allPaths.Add(currentPath);
                return matrix;
            }

            if (currentPosition != "*")
            {
                var currentCoordinates = new MatrixCellCoordinates(rowPosition, colPosition);
                if (!currentPath.Contains(currentCoordinates))
                {
                    currentPath.Enqueue(currentCoordinates);
                }

                matrix[rowPosition, colPosition] = "x";
            }

            var path = new Queue<MatrixCellCoordinates>(currentPath);

            var nextCoordinates = new MatrixCellCoordinates(rowPosition + 1, colPosition);
            if (lastDirection != Directions.Up && !currentPath.Contains(nextCoordinates))
            {
                matrix = MoveInDirection(matrix, rowPosition + 1, colPosition, path, Directions.Down);
                matrix[rowPosition, colPosition] = "0";
            }

            nextCoordinates = new MatrixCellCoordinates(rowPosition, colPosition + 1);
            if (lastDirection != Directions.Left && !currentPath.Contains(nextCoordinates))
            {
                path = new Queue<MatrixCellCoordinates>(currentPath);
                matrix = MoveInDirection(matrix, rowPosition, colPosition + 1, path, Directions.Right);
                matrix[rowPosition, colPosition] = "0";
            }

            nextCoordinates = new MatrixCellCoordinates(rowPosition, colPosition - 1);
            if (lastDirection != Directions.Right && !currentPath.Contains(nextCoordinates))
            {
                path = new Queue<MatrixCellCoordinates>(currentPath);
                matrix = MoveInDirection(matrix, rowPosition, colPosition - 1, path, Directions.Left);
                matrix[rowPosition, colPosition] = "0";
            }

            nextCoordinates = new MatrixCellCoordinates(rowPosition - 1, colPosition);
            if (lastDirection != Directions.Down && !currentPath.Contains(nextCoordinates))
            {
                path = new Queue<MatrixCellCoordinates>(currentPath);
                matrix = MoveInDirection(matrix, rowPosition - 1, colPosition, path, Directions.Up);
                matrix[rowPosition, colPosition] = "0";
            }

            return matrix;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}

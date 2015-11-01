namespace Labyrinth
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[,] labyrinth = new string[,]
            {
                { "0", "0", "0", "x", "0", "x" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "*", "x", "0", "x", "0" },
                { "0", "x", "0", "0", "0", "0" },
                { "0", "0", "0", "x", "x", "0" },
                { "0", "0", "0", "x", "0", "x" },
            };

            Console.WriteLine("Initial labyrinth:");
            PrintLabyrinth(labyrinth);

            string[,] result = labyrinth;

            result = MoveInDirection(result, 2, 1, 0);
            result = MarkUnreachableCells(result);

            Console.WriteLine();
            Console.WriteLine("Calculated steps:");
            PrintLabyrinth(result);
        }

        private static string[,] MoveInDirection(string[,] labyrinth, int rowPosition, int colPosition, int stepsCount)
        {
            bool positionIsInRangeOfTheLabyrinth =
                   ((colPosition >= 0 && colPosition < labyrinth.GetLength(0)) && (rowPosition >= 0 && rowPosition < labyrinth.GetLength(1)));

            if (!positionIsInRangeOfTheLabyrinth)
            {
                return labyrinth;
            }

            string currentPosition = labyrinth[rowPosition, colPosition];

            bool cellIsNotAvailable = currentPosition == "x";

            if (cellIsNotAvailable)
            {
                return labyrinth;
            }

            int currentNumber = 0;
            bool cellIsNumber = int.TryParse(currentPosition, out currentNumber);

            if (cellIsNumber)
            {
                bool cellIsGreaterThanZero = currentNumber > 0;
                bool currentStepIsLessThanCurrentValue = currentNumber > stepsCount;

                if (cellIsGreaterThanZero && !currentStepIsLessThanCurrentValue)
                {
                    return labyrinth;
                }
            }

            if (currentPosition != "*")
            {
                stepsCount += 1;
                labyrinth[rowPosition, colPosition] = stepsCount.ToString();
            }

            labyrinth = MoveInDirection(labyrinth, rowPosition + 1, colPosition, stepsCount);
            labyrinth = MoveInDirection(labyrinth, rowPosition, colPosition + 1, stepsCount);
            labyrinth = MoveInDirection(labyrinth, rowPosition, colPosition - 1, stepsCount);
            labyrinth = MoveInDirection(labyrinth, rowPosition - 1, colPosition, stepsCount);

            return labyrinth;
        }

        private static string[,] MarkUnreachableCells(string[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "u";
                    }
                }
            }

            return labyrinth;
        }

        private static void PrintLabyrinth(string[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    Console.Write(" {0} ", labyrinth[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
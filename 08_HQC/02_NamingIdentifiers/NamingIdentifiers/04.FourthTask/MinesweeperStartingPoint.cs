namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class MinesweeperStartingPoint
    {
        public static char[,] Playfield { get; set; }

        public static void Main(string[] arguments)
        {
            const int MAXIMUM_POINTS = 35;

            string command = string.Empty;
            char[,] playField = CreatePlayfield();
            char[,] bombs = PlaceBombs();

            int currentPoints = 0;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int col = 0;

            bool showGreetengsMessage = true;
            bool hasMaxPoints = false;
            bool steppedOnBomb = false;

            do
            {
                if (showGreetengsMessage)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try your luck to find all the fields without bombs." +
                    " The 'top' command shows the scoreboard, 'restart' starts new game, 'exit' exits the game!");

                    PrintBoard(playField);
                    showGreetengsMessage = false;
                }

                Console.Write("Write command or select row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= playField.GetLength(0) &&
                        col <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintScoreboard(champions);
                        break;
                    case "restart":
                        playField = CreatePlayfield();
                        bombs = PlaceBombs();
                        PrintBoard(playField);
                        steppedOnBomb = false;
                        showGreetengsMessage = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                GetMove(playField, bombs, row, col);
                                currentPoints++;
                            }

                            if (MAXIMUM_POINTS == currentPoints)
                            {
                                hasMaxPoints = true;
                            }
                            else
                            {
                                PrintBoard(playField);
                            }
                        }
                        else
                        {
                            steppedOnBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (steppedOnBomb)
                {
                    PrintBoard(bombs);

                    Console.Write("\nHrrrrrr! You have died like a hero with {0} points. Enter your nickname: ", currentPoints);

                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, currentPoints);

                    if (champions.Count < 5)
                    {
                        champions.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < player.Points)
                            {
                                champions.Insert(i, player);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    PrintScoreboard(champions);

                    playField = CreatePlayfield();
                    bombs = PlaceBombs();
                    currentPoints = 0;
                    steppedOnBomb = false;
                    showGreetengsMessage = true;
                }

                if (hasMaxPoints)
                {
                    Console.WriteLine("\nCongratulations! You have opened 35 cells without losing single drop of blood.");
                    PrintBoard(bombs);

                    Console.WriteLine("Enter your name: ");

                    string name = Console.ReadLine();
                    Player player = new Player(name, currentPoints);
                    champions.Add(player);

                    PrintScoreboard(champions);

                    Playfield = CreatePlayfield();
                    bombs = PlaceBombs();
                    currentPoints = 0;
                    hasMaxPoints = false;
                    showGreetengsMessage = true;
                }
            } while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Good bye.");
            Console.Read();
        }

        private static void PrintScoreboard(List<Player> points)
        {
            Console.WriteLine("\nPoints:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells.", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The scoreboard is empty!\n");
            }
        }

        private static void GetMove(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = BombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayfield()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playfield = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playfield[i, j] = '-';
                }
            }

            List<int> randomCoordinatesCoefficients = new List<int>();

            while (randomCoordinatesCoefficients.Count < 15)
            {
                Random random = new Random();
                int currentNumber = random.Next(50);

                if (!randomCoordinatesCoefficients.Contains(currentNumber))
                {
                    randomCoordinatesCoefficients.Add(currentNumber);
                }
            }

            foreach (int coefficient in randomCoordinatesCoefficients)
            {
                int currentCol = coefficient / cols;
                int currentRow = coefficient % cols;

                if (currentRow == 0 && coefficient != 0)
                {
                    currentCol--;
                    currentRow = cols;
                }
                else
                {
                    currentRow++;
                }

                playfield[currentCol, currentRow - 1] = '*';
            }

            return playfield;
        }

        private static char BombsCount(char[,] board, int currentRow, int currentCol)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (board[currentRow - 1, currentCol] == '*')
                {
                    count++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (board[currentRow + 1, currentCol] == '*')
                {
                    count++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (board[currentRow, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if (currentCol + 1 < cols)
            {
                if (board[currentRow, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (board[currentRow - 1, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < cols))
            {
                if (board[currentRow - 1, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (board[currentRow + 1, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol + 1 < cols))
            {
                if (board[currentRow + 1, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}

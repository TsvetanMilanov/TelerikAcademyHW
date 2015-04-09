using System;
using System.Threading;
using System.Collections.Generic;

/*Problem 12.** Falling Rocks

Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
 */

struct Rock
{
    public int x;
    public int y;
    public char character;
    public ConsoleColor color;
}

struct Troll
{
    public int x;
    public int y;
    public char character;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }

    static void PrintInfoOnPosition(int x, int y, string info, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(info);
    }
    static void Main(string[] args)
    {
        //set the console size
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 90;

        int fieldWidth = 60;

        int lives = 3;

        int score = 0;

        Random random = new Random();

        char[] rocksSymbols = { '#', '@', '^', '&', '*', '$', '+', '%', '!', '.', ';', '-' }; //Rocks symbols

        //Create the troll
        Troll troll = new Troll();
        troll.x = fieldWidth / 2;
        troll.y = Console.WindowHeight - 2;
        troll.color = ConsoleColor.Green;
        troll.character = 'O';



        List<Rock> rocks = new List<Rock>(); //Rocks list with positions and ...

        while (true)
        {
            //Adding random rock to the field
            Rock nextRock = new Rock();
            nextRock.color = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue(random.Next(16)); //Random color for rock
            nextRock.x = random.Next(0, fieldWidth);
            nextRock.y = 0;
            nextRock.character = (char)rocksSymbols.GetValue(random.Next(rocksSymbols.Length)); //Random char for rock
            rocks.Add(nextRock);

            //Check if key is pressed
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                //Clear key buffer
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                //Move car with left and right arrow
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (troll.x - 1 >= 0)
                    {
                        troll.x--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (troll.x + 1 <= fieldWidth)
                    {
                        troll.x++;
                    }
                }
            }

            //Create new list to fix the falling rocks
            List<Rock> newList = new List<Rock>();

            //Make rocks fall
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock = oldRock;
                newRock.y++;

                //Check if rock hits the troll
                if (newRock.y == troll.y && newRock.x == troll.x)
                {
                    lives--;
                    rocks.Clear();
                    Console.Beep();
                    if (lives <= 0)
                    {
                        Console.Clear();
                        PrintInfoOnPosition(35, 15, "Score: " + score, ConsoleColor.White);
                        PrintInfoOnPosition(35, 20, "GAME OVER!!!", ConsoleColor.Red);
                        Environment.Exit(0);
                    }
                }

                //Add rock to the newList if newRock.y is not greater than the console height
                if (newRock.y < Console.WindowHeight - 1)
                {
                    newList.Add(newRock);
                }
                else
                {
                    score++;
                }
            }
            rocks = newList;

            //Clear the console to print new list and troll
            Console.Clear();

            //Print troll
            PrintOnPosition(troll.x, troll.y, troll.character, troll.color);

            //Print all rocks
            foreach (Rock rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.character, rock.color);
            }

            //Print info
            PrintInfoOnPosition(65, 1, "Falling Rocks game", ConsoleColor.Blue);
            PrintInfoOnPosition(70, 17, "Lives: " + lives, ConsoleColor.White);
            PrintInfoOnPosition(70, 18, "Score: " + score, ConsoleColor.White);

            //Slow the game speed
            Thread.Sleep(150);
        }
    }
}

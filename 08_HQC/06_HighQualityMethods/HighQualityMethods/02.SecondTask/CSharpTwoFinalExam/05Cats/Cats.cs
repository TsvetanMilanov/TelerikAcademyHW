namespace Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Cats
    {
        public static void Main(string[] args)
        {
            string[] cats = Console.ReadLine().Split(' ').ToArray();
            int numberOfCats = int.Parse(cats[0]);

            string[] songs = Console.ReadLine().Split(' ').ToArray();
            int numberOfSongs = int.Parse(songs[0]);

            List<string> allCommands = ReadCommandsFromConsole();

            int[,] tableOfSongsSangByCat = LinkSongsWithCats(allCommands, numberOfSongs, numberOfCats);

            bool[] songSangState = new bool[numberOfCats];

            int counter = 1;
            bool skipSong = true;

            for (int i = 0; i < numberOfSongs; i++)
            {
                for (int j = 0; j < numberOfCats; j++)
                {
                    if (tableOfSongsSangByCat[i, j] == 1)
                    {
                        if (songSangState[j] == false)
                        {
                            songSangState[j] = true;
                            skipSong = true;
                        }
                    }
                    else
                    {
                        skipSong = false;
                    }
                }

                if (songSangState.Contains(false) && skipSong)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    return;
                }
            }

            if (songSangState.Contains(false))
            {
                Console.WriteLine("No concert!");
            }
            else
            {
                Console.WriteLine(counter);
            }
        }

        private static int[,] LinkSongsWithCats(List<string> allCommands, int numberOfSongs, int numberOfCats)
        {
            int[,] tableOfSongsSangByCat = new int[numberOfSongs, numberOfCats];

            foreach (var currentCommand in allCommands)
            {
                string[] result = currentCommand.Split(' ');
                int cat = int.Parse(result[1]) - 1;
                int song = int.Parse(result[result.GetLength(0) - 1]) - 1;

                tableOfSongsSangByCat[song, cat] = 1;
            }

            return tableOfSongsSangByCat;
        }

        private static List<string> ReadCommandsFromConsole()
        {
            List<string> allCommands = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command != "Mew!")
                {
                    allCommands.Add(command);
                }
                else
                {
                    break;
                }
            }

            return allCommands;
        }
    }
}

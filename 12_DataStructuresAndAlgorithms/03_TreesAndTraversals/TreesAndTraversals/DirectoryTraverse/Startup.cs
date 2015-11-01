namespace DirectoryTraverse
{
    using System;
    using System.IO;

    public class Startup
    {
        private const string DirectoryToTraverse = @"C:\Windows";
        private const string FileExtension = ".exe";

        public static void Main()
        {
            PrintAllMatchingFilesInDirectory(DirectoryToTraverse);
        }

        private static void PrintAllMatchingFilesInDirectory(string directoryToTraverse)
        {
            string[] subDirectoriesInCurrentDirectory = new string[0];
            string[] filesInCurrentDirectory = new string[0];

            try
            {
                subDirectoriesInCurrentDirectory = Directory.GetDirectories(directoryToTraverse);
                filesInCurrentDirectory = Directory.GetFiles(directoryToTraverse);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Cannot access folder: {0}", directoryToTraverse);
            }

            bool shouldDisplayDirectory = true;

            foreach (var file in filesInCurrentDirectory)
            {
                if (file.EndsWith(FileExtension))
                {
                    if (shouldDisplayDirectory)
                    {
                        Console.WriteLine("\n{0}", directoryToTraverse);
                        shouldDisplayDirectory = false;
                    }

                    var fileParts = file.Split('\\');
                    string fileName = fileParts[fileParts.Length - 1];
                    Console.WriteLine("\t{0}", fileName);
                }
            }

            foreach (var directory in subDirectoriesInCurrentDirectory)
            {
                PrintAllMatchingFilesInDirectory(directory);
            }
        }
    }
}

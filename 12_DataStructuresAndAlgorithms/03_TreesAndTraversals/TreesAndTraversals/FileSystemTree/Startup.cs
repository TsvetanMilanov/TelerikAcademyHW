namespace FileSystemTree
{
    using System;
    using System.IO;

    public class Startup
    {
        private const string RootDirectory = @"C:\Windows";

        public static void Main()
        {
            Folder rootDirectory = CreatiDirectoryWithFiles(RootDirectory);

            FileSystemTree fileSystemTree = new FileSystemTree(rootDirectory);

            Console.WriteLine("\nEnter the directory:");
            string directoryToCalculateSizeOf = Console.ReadLine();

            long sizeOfDirectory = fileSystemTree.CalculateSizeOfFilesInDirectory(directoryToCalculateSizeOf);

            Console.WriteLine("The size of {0} is: {1} bytes", directoryToCalculateSizeOf, sizeOfDirectory);
        }

        private static Folder CreatiDirectoryWithFiles(string rootDirectory)
        {
            DirectoryInfo directoryInfo = null;
            FileInfo[] filesInformation = null;

            string[] subDirectoriesInCurrentDirectory = new string[0];

            try
            {
                directoryInfo = new DirectoryInfo(rootDirectory);
                filesInformation = directoryInfo.GetFiles();
                subDirectoriesInCurrentDirectory = Directory.GetDirectories(rootDirectory);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Cannot access folder: {0}", rootDirectory);
            }

            File[] files = new File[0];

            if (filesInformation != null)
            {
                files = new File[filesInformation.Length];

                for (int i = 0; i < filesInformation.Length; i++)
                {
                    var currentFileInformation = filesInformation[i];

                    files[i] = new File(currentFileInformation.Name, (int)currentFileInformation.Length);
                }
            }

            Folder[] folders = new Folder[subDirectoriesInCurrentDirectory.Length];

            for (int i = 0; i < subDirectoriesInCurrentDirectory.Length; i++)
            {
                string currentSubDirectoryPath = subDirectoriesInCurrentDirectory[i];

                folders[i] = CreatiDirectoryWithFiles(currentSubDirectoryPath);
            }

            Folder result = new Folder(rootDirectory, files, folders);

            return result;
        }
    }
}

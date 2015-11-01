namespace FileSystemTree
{
    public class FileSystemTree
    {
        public FileSystemTree(Folder rootDirectory)
        {
            this.RootDirectory = rootDirectory;
        }

        public Folder RootDirectory { get; set; }

        public long CalculateSizeOfFilesInDirectory(string directory)
        {
            Folder folderToSearch = this.FindFolder(this.RootDirectory, directory);

            if (folderToSearch == null)
            {
                return -1;
            }

            long result = folderToSearch.CalculateSize();

            return result;
        }

        private Folder FindFolder(Folder rootDirectory, string directory)
        {
            if (rootDirectory.Name == directory)
            {
                return rootDirectory;
            }

            Folder result = null;

            foreach (var subDirectory in rootDirectory.ChildFolders)
            {
                result = this.FindFolder(subDirectory, directory);

                if (result != null)
                {
                    return result;
                }
            }

            return result;
        }
    }
}

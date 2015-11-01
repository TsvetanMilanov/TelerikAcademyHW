namespace FileSystemTree
{
    using System.Linq;

    public class Folder
    {
        public Folder(string name, File[] files, Folder[] folders)
        {
            this.Name = name;
            this.Files = files;
            this.ChildFolders = folders;
        }

        public string Name { get; set; }

        public File[] Files { get; set; }

        public Folder[] ChildFolders { get; set; }
        
        public long CalculateSize()
        {
            long sum = 0;

            foreach (var subDirectory in this.ChildFolders)
            {
                sum += subDirectory.CalculateSize();
            }

            foreach (var file in this.Files)
            {
                sum += file.Size;
            }

            return sum;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}

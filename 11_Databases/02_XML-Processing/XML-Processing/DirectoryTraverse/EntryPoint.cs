namespace DirectoryTraverse
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            DirectoryTraverser traverser = new DirectoryTraverser();

            traverser.CreateXmlFileForDirectory("../../../directory.xml", "../../../");

            Console.WriteLine("File directory.xml created!");
        }
    }
}

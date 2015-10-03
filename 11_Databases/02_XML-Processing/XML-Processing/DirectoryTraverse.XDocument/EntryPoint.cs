namespace DirectoryTraverse
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            DirectoryTraverser traverser = new DirectoryTraverser();

            traverser.CreateXmlFileForDirectory("../../../directory-with-XDocument.xml", "../../../");

            Console.WriteLine("File directory-with-XDocument.xml created!");
        }
    }
}

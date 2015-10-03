namespace DirectoryTraverse
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;

    public class DirectoryTraverser
    {
        public void CreateXmlFileForDirectory(string outputFilepath, string directoryToTraverse)
        {
            XDocument document = new XDocument();
            
            XElement rootElement = new XElement("directory");

            this.AddDirectoryElement(rootElement, directoryToTraverse);
            document.Add(rootElement);
            document.Save(outputFilepath);
        }

        private void AddFileElement(XElement parentElement, string fileName)
        {
            var fileElement = new XElement("file", fileName);
            parentElement.Add(fileElement);
        }

        private void AddDirectoryElement(XElement parentElement, string directoryToTraverse)
        {
            var dirElement = new XElement("dir");
            dirElement.SetAttributeValue("path", directoryToTraverse);

            string[] directory = Directory.GetDirectories(directoryToTraverse);
            string[] files = Directory.GetFiles(directoryToTraverse);

            foreach (var dir in directory)
            {
                this.AddDirectoryElement(dirElement, dir);
            }

            foreach (var file in files)
            {
                this.AddFileElement(dirElement, file.Split(new string[] { directoryToTraverse }, StringSplitOptions.RemoveEmptyEntries)[0]);
            }

            parentElement.Add(dirElement);
        }
    }
}

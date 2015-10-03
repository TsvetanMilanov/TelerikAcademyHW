namespace DirectoryTraverse
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class DirectoryTraverser
    {
        public void CreateXmlFileForDirectory(string outputFilepath, string directoryToTraverse)
        {
            XmlTextWriter writer = new XmlTextWriter(outputFilepath, Encoding.Unicode);

            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;

            writer.WriteStartDocument();
            writer.WriteStartElement("directory");

            this.CreateXmlForContentOfDirectory(writer, directoryToTraverse);

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Dispose();
        }

        private void CreateFileElement(XmlWriter writer, string fileName)
        {
            writer.WriteStartElement("file");
            writer.WriteString(fileName);
            writer.WriteEndElement();
        }

        private void CreateXmlForContentOfDirectory(XmlWriter writer, string directoryToTraverse)
        {
            writer.WriteStartElement("dir");
            writer.WriteStartAttribute("path");
            writer.WriteString(directoryToTraverse);
            writer.WriteEndAttribute();

            string[] directory = Directory.GetDirectories(directoryToTraverse);
            string[] files = Directory.GetFiles(directoryToTraverse);

            foreach (var dir in directory)
            {
                this.CreateXmlForContentOfDirectory(writer, dir);
            }

            foreach (var file in files)
            {
                this.CreateFileElement(writer, file.Split(new string[] { directoryToTraverse }, StringSplitOptions.RemoveEmptyEntries)[0]);
            }

            writer.WriteEndElement();
        }
    }
}

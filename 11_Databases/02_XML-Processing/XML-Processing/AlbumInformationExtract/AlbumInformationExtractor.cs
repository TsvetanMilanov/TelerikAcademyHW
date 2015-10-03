namespace AlbumInformationExtract
{
    using System.Text;
    using System.Xml;

    public class AlbumInformationExtractor
    {
        public void WriteInformationToFile(string inputFilePath, string outputFilePath)
        {
            XmlReader reader = XmlReader.Create(inputFilePath);
            XmlWriter writer = new XmlTextWriter(outputFilePath, Encoding.Unicode);

            writer.WriteStartDocument();
            writer.WriteStartElement("albums");

            while (reader.Read())
            {
                if (reader.Name == "album" && reader.NodeType != XmlNodeType.EndElement)
                {
                    writer.WriteStartElement("album");

                    reader.ReadToFollowing("name");
                    this.WriteElement(writer, "name", reader.ReadInnerXml());

                    reader.ReadToFollowing("artist");
                    this.WriteElement(writer, "author", reader.ReadInnerXml());

                    writer.WriteEndElement();
                }
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();

            reader.Dispose();
            writer.Dispose();
        }

        private void WriteElement(XmlWriter writer, string elementName, string elementValue)
        {
            writer.WriteStartElement(elementName);
            writer.WriteString(elementValue);
            writer.WriteEndElement();
        }
    }
}

namespace CreatePeopleXmlFromTextFile
{
    using System.IO;
    using System.Xml;

    public class XmlDocumentCreator
    {
        public XmlDocument CreateFromTextFile(string textFilePath)
        {
            XmlDocument document = new XmlDocument();
            XmlElement rootElement = document.CreateElement("people");

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    XmlElement currentPerson = this.ParsePersonElement(streamReader, document, currentLine);

                    rootElement.AppendChild(currentPerson);

                    currentLine = streamReader.ReadLine();
                }
            }

            document.AppendChild(rootElement);

            return document;
        }

        private XmlElement ParsePersonElement(StreamReader streamReader, XmlDocument document, string currentLineContent)
        {
            XmlElement person = document.CreateElement("person");
            XmlElement name = document.CreateElement("name");
            XmlElement address = document.CreateElement("address");
            XmlElement phone = document.CreateElement("phone");

            name.InnerText = currentLineContent;

            address.InnerText = streamReader.ReadLine();
            phone.InnerText = streamReader.ReadLine();

            person.AppendChild(name);
            person.AppendChild(address);
            person.AppendChild(phone);

            return person;
        }
    }
}

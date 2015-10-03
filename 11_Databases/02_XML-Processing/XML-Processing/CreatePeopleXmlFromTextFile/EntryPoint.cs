namespace CreatePeopleXmlFromTextFile
{
    using System;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlDocumentCreator documentCreator = new XmlDocumentCreator();

            XmlDocument document = documentCreator.CreateFromTextFile("../../../people.txt");

            document.Save("../../../people.xml");
            Console.WriteLine("File people.xml created!");
        }
    }
}

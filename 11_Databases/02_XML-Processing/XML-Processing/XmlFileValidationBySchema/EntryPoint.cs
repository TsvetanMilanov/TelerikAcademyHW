namespace XmlFileValidationBySchema
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlFormatValidator validator = new XmlFormatValidator();

            //// valid XML
            bool isXmlValid = validator.CheckFileAgainstSchema("../../../catalog.xml", "../../../catalogSchema.xsd");

            //// invalid XML
            //// bool isXmlValid = validator.CheckFileAgainstSchema("../../../catalog-invalid.xml", "../../../catalogSchema.xsd");

            Console.WriteLine("The XML is: {0}", isXmlValid ? "valid" : "invalid");
        }
    }
}

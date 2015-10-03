namespace XmlFileValidationBySchema
{
    using System.Xml;
    using System.Xml.Schema;

    public class XmlFormatValidator
    {
        public bool CheckFileAgainstSchema(string inputFilePath, string inputSchemaPath)
        {
            bool isFormatValid = true;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add(null, inputSchemaPath);

            XmlReader reader = XmlReader.Create(inputFilePath, settings);
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(reader);
            }
            catch
            {
                isFormatValid = false;
            }

            return isFormatValid;
        }
    }
}

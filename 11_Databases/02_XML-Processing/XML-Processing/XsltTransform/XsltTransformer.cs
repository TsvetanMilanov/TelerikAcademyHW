namespace XsltTransform
{
    using System.Xml.Xsl;

    public class XsltTransformer
    {
        public void TransformXmlToHtml(string inputFilePath, string stylesheetFilePath, string outputFilePath)
        {
            XslCompiledTransform stylesheet = new XslCompiledTransform();
            stylesheet.Load(stylesheetFilePath);

            stylesheet.Transform(inputFilePath, outputFilePath);
        }
    }
}

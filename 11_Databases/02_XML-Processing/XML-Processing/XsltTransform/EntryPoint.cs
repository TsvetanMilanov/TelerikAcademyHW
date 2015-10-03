namespace XsltTransform
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            XsltTransformer transformer = new XsltTransformer();

            transformer.TransformXmlToHtml(
                "../../../catalog-backup.xml",
                "../../../CatalogToHTML.xslt",
                "../../../catalog-output.html");

            Console.WriteLine("XML transformed to HTML in catalog-output.html!");
        }
    }
}
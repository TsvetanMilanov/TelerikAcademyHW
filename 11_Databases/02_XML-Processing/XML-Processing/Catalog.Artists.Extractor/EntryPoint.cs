namespace Catalog.Artists.Extractor
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlCatalogArtistsExtractor xmlExtractor = new XmlCatalogArtistsExtractor();

            string xmlDocumentPath = "../../../catalog.xml";

            Dictionary<string, int> extractedArtists = xmlExtractor.GetDiffetentArtistsFromDocument(xmlDocumentPath);

            Console.WriteLine("Artists:");

            foreach (var artist in extractedArtists)
            {
                Console.WriteLine("{0} has {1} albums in the catalog.", artist.Key, artist.Value);
            }
        }
    }
}

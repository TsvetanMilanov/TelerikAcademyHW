namespace Catalog.Artists.Extractor
{
    using System.Collections.Generic;
    using System.Xml;

    public class XmlCatalogArtistsExtractor
    {
        public Dictionary<string, int> GetDiffetentArtistsFromDocument(string xmlDocumentPath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlDocumentPath);

            Dictionary<string, int> artistsWithAlbumsCount = new Dictionary<string, int>();
            var allArtists = xmlDocument.GetElementsByTagName("artist");

            for (int i = 0; i < allArtists.Count; i++)
            {
                var currentArtistName = allArtists.Item(i).InnerText;

                if (artistsWithAlbumsCount.ContainsKey(currentArtistName))
                {
                    artistsWithAlbumsCount[currentArtistName] += 1;
                }
                else
                {
                    artistsWithAlbumsCount.Add(currentArtistName, 1);
                }
            }

            return artistsWithAlbumsCount;
        }
    }
}

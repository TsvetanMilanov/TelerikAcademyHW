namespace Catalog.SongTitles.Extractor
{
    using System.Collections.Generic;
    using System.Xml;

    public class XmlCatalogSongTitlesExtractor
    {
        public IEnumerable<string> GetSongTitlesFromCatalog(string xmlDocumentPath)
        {
            var songTitles = new List<string>();

            using (XmlReader reader = XmlReader.Create(xmlDocumentPath))
            {
                while (reader.Read())
                {
                    var currentNode = reader;

                    if (currentNode.Name == "song")
                    {
                        currentNode.ReadToDescendant("title");

                        songTitles.Add(currentNode.ReadInnerXml());
                    }
                }
            }

            return songTitles;
        }
    }
}

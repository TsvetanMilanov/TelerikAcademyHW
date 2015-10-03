namespace Catalog.SongTitles.Extract
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class XmlSongTitlesExtractor
    {
        public IEnumerable<string> GetSongTitles(string xmlDocumentPath)
        {
            XDocument document = XDocument.Load(xmlDocumentPath);

            IEnumerable<string> songTitles =
                from song in document.Descendants("song")
                select song.Element("title").Value.ToString();

            return songTitles;
        }
    }
}

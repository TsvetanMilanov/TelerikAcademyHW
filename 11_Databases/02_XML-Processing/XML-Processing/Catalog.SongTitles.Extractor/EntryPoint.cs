namespace Catalog.SongTitles.Extractor
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlCatalogSongTitlesExtractor songTitlesExtractor = new XmlCatalogSongTitlesExtractor();

            IEnumerable<string> songTitles = songTitlesExtractor.GetSongTitlesFromCatalog("../../../catalog.xml");

            Console.WriteLine("All song titles:");
            foreach (var title in songTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}

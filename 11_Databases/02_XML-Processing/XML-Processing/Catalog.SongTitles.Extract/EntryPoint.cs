namespace Catalog.SongTitles.Extract
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlSongTitlesExtractor songTitlesExtractor = new XmlSongTitlesExtractor();

            IEnumerable<string> songTitles = songTitlesExtractor.GetSongTitles("../../../catalog.xml");

            Console.WriteLine("All song titles:");

            foreach (var title in songTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}

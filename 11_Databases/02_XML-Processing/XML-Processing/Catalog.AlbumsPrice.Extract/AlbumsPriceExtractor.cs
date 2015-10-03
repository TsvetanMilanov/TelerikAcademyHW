namespace Catalog.AlbumsPrice.Extract
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    public class AlbumsPriceExtractor
    {
        public IEnumerable<string> GetPricesOfAlbumsPublishedFiveYearsBefore(string xmlFilePath, DateTime date)
        {
            var pricesOfAlbums = new List<string>();

            XmlDocument document = new XmlDocument();
            document.Load(xmlFilePath);

            var selectedAlbums = document.SelectNodes("/albums/album[year - " + date.Year + " < -5]");

            for (int i = 0; i < selectedAlbums.Count; i++)
            {
                var currentAlbum = selectedAlbums.Item(i);

                pricesOfAlbums.Add(currentAlbum.SelectSingleNode("price").InnerText);
            }

            return pricesOfAlbums;
        }
    }
}

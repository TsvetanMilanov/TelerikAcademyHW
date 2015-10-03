namespace Catalog.AlbumsPrice.Extract.XQuery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class AlbumsPriceExtractor
    {
        public IEnumerable<string> GetPricesOfAlbumsPublishedFiveYearsBefore(string xmlFilePath, DateTime date)
        {
            XDocument document = XDocument.Load(xmlFilePath);

            var selectedAlbumsPrices = from element in document.Descendants("album")
                                       where (int.Parse(element.Element("year").Value) - date.Year < -5)
                                       select element.Element("price").Value;

            return selectedAlbumsPrices;
        }
    }
}

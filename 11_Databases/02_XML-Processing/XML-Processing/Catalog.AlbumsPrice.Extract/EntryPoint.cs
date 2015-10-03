namespace Catalog.AlbumsPrice.Extract
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            AlbumsPriceExtractor albumsPriceExtractor = new AlbumsPriceExtractor();

            IEnumerable<string> prices =
                albumsPriceExtractor.GetPricesOfAlbumsPublishedFiveYearsBefore("../../../catalog-backup.xml", DateTime.Now);

            Console.WriteLine("All prices:");

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}

namespace Articles
{
    using System;

    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            OrderedMultiDictionary<decimal, Article> articlesByPrice = new OrderedMultiDictionary<decimal, Article>(true);

            AddRandomArticles(articlesByPrice);

            var articlesInPriceRange = articlesByPrice.Range(500, true, 800, true);

            foreach (var pair in articlesInPriceRange)
            {
                foreach (var item in pair.Value)
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, item.Title);
                }
            }
        }

        private static void AddRandomArticles(OrderedMultiDictionary<decimal, Article> articlesByPrice)
        {
            for (int i = 0; i < 1000; i++)
            {
                string randomTitle = "Random Title #" + i;
                string randomVendor = "Random Vendor #" + i;
                string randomBarcode = "Random Barcode #" + 1;
                decimal randomPrice = (decimal)(100000 % (i + 1) + 500);

                Article currentArticle = new Article
                {
                    Title = randomTitle,
                    Vendor = randomVendor,
                    Barcode = randomBarcode,
                    Price = randomPrice
                };

                articlesByPrice.Add(currentArticle.Price, currentArticle);
            }
        }
    }
}

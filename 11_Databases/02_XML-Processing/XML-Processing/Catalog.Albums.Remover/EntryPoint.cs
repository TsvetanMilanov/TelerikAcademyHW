namespace Catalog.Albums.Remover
{
    using System;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            string xmlDocumentPath = "../../../catalog.xml";
            XmlCatalogAlbumsRemover albumsRemover = new XmlCatalogAlbumsRemover();

            var documentAfterRemovingAlbums =
                albumsRemover.RemoveAlbumsFromCatalogWithBigPrice(xmlDocumentPath, 20);
            var allAlbums = documentAfterRemovingAlbums.SelectNodes("/albums/album");

            Console.WriteLine("Albums with price less than 20 after the deleting of the other albums:");
            for (int i = 0; i < allAlbums.Count; i++)
            {
                var currentAlbum = allAlbums.Item(i);

                Console.WriteLine("{0} has price: {1}", currentAlbum.SelectSingleNode("name").InnerText, currentAlbum.SelectSingleNode("price").InnerText);
            }

            documentAfterRemovingAlbums.Save(xmlDocumentPath);
        }
    }
}
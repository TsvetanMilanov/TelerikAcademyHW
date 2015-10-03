namespace Catalog.Albums.Remover
{
    using System.Xml;

    public class XmlCatalogAlbumsRemover
    {
        public XmlDocument RemoveAlbumsFromCatalogWithBigPrice(string xmlDocumentPath, int price)
        {
            XmlDocument document = new XmlDocument();
            document.Load(xmlDocumentPath);

            var allAlbumsWithBigPrice = document.SelectNodes("/albums/album[price > 20]");
            var allAlbums = document.SelectSingleNode("/albums");

            for (int i = 0; i < allAlbumsWithBigPrice.Count; i++)
            {
                var currentAlbum = allAlbumsWithBigPrice.Item(i);
                var parentNode = currentAlbum.ParentNode;
                parentNode.RemoveChild(currentAlbum);
            }

            return document;
        }
    }
}

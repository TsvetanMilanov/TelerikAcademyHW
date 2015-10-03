namespace AlbumInformationExtract
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            AlbumInformationExtractor albumInformationExtractor = new AlbumInformationExtractor();

            albumInformationExtractor.WriteInformationToFile("../../../catalog.xml", "../../../album.xml");

            Console.WriteLine("File album.xml created!");
        }
    }
}

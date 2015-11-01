namespace ArtistsSystem.Client.Console
{
    using System;
    using System.Net.Http;

    using RequestHandlers;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter the WebApi BASE URI (http://localhost:11227): ");
            string baseUri = Console.ReadLine();

            HttpClient client = new HttpClient();
            
            TestAlbumsServicesWithJson(baseUri, client);
            TestAlbumsServicesWithXml(baseUri, client);
            TestArtistsServicesWithJson(baseUri, client);
            TestArtistsServicesWithXml(baseUri, client);
            TestSongsServicesWithJson(baseUri, client);
            TestSongsServicesWithXml(baseUri, client);
        }

        private static void TestAlbumsServicesWithJson(string baseUri, HttpClient client)
        {
            IRequestsHandler albumsHandler = new RequestsHandler(baseUri, "albums", client, "application/json");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all albums...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get album by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.GetById(1));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to add album...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.Post("{\"title\" : \"Asdf\", \"producerId\" : 1 }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to edit album...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.Put(1, "{\"title\" : \"Asdf\", \"producerId\" : 1 }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to delete album...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            albumsHandler.Delete(5);
        }

        private static void TestAlbumsServicesWithXml(string baseUri, HttpClient client)
        {
            IRequestsHandler albumsHandler = new RequestsHandler(baseUri, "albums", client, "application/xml");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all albums...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get album by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(albumsHandler.GetById(1));
        }

        private static void TestArtistsServicesWithJson(string baseUri, HttpClient client)
        {
            IRequestsHandler artistsHandler = new RequestsHandler(baseUri, "artists", client, "application/json");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all artists...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get artist by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.GetById(1));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to add artist...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.Post("{ \"name\" : \"Gosho\" }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to edit artist...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.Put(1, "{ \"name\" : \"Gosho\" }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to delete artist...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            artistsHandler.Delete(5);
        }

        private static void TestArtistsServicesWithXml(string baseUri, HttpClient client)
        {
            IRequestsHandler artistsHandler = new RequestsHandler(baseUri, "artists", client, "application/xml");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all artists...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get artist by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(artistsHandler.GetById(1));
        }

        private static void TestSongsServicesWithJson(string baseUri, HttpClient client)
        {
            IRequestsHandler songsHandler = new RequestsHandler(baseUri, "songs", client, "application/json");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all songs...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get song by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.GetById(1));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to add song...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.Post("{ \"title\": \"Postman\", \"artistId\" : 1, \"albumId\": 1 }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to edit song...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.Put(1, "{ \"title\": \"Postman\", \"artistId\" : 1, \"albumId\": 1 }"));
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to delete song...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            songsHandler.Delete(5);
        }

        private static void TestSongsServicesWithXml(string baseUri, HttpClient client)
        {
            IRequestsHandler songsHandler = new RequestsHandler(baseUri, "songs", client, "application/xml");

            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get all songs...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.Get());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("Press Enter to get song by id...");
            Console.WriteLine("\n=================================\n");
            Console.ReadKey();
            Console.WriteLine(songsHandler.GetById(1));
        }
    }
}
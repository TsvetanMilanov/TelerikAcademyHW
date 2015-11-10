namespace FeedZilla.Client.Webclient
{
    using System;
    using System.Net;

    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            WebClient client = new WebClient();
            client.BaseAddress = @"http://jsonplaceholder.typicode.com/";

            Console.Write("Enter the id of the post: ");
            int postId = int.Parse(Console.ReadLine());

            string request = string.Format("/posts/{0}", postId);

            var response = client.DownloadString(request);

            PostResponseModel postResponse = JsonConvert.DeserializeObject<PostResponseModel>(response);

            Console.WriteLine("\nTitle: {0}\n\nBody:\n{1}", postResponse.Title, postResponse.Body);
        }
    }
}

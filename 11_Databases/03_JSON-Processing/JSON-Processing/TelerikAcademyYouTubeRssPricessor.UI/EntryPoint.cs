namespace TelerikAcademyYouTubeRssProcessor.UI
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using TelerikAcademyYouTubeRssProcessor.Logic;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string downloadedRssFilePath = "../../../TelerikAcademyRss.txt";

            //// Get the RSS feed of Telerik Academy
            WebClient webClient = new WebClient();
            webClient.DownloadFile(
                "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw",
                downloadedRssFilePath);

            JsonProcessor jsonProcessor = new JsonProcessor();

            //// Convert the downloaded XML to JSON
            string convertedJson = jsonProcessor.ParseXmlToJson(downloadedRssFilePath);

            IEnumerable<string> allVideoTitles = jsonProcessor.GetVideoTitlesFromJson(convertedJson);

            Console.WriteLine("All video titles:");
            foreach (var videoTitle in allVideoTitles)
            {
                Console.WriteLine(videoTitle);
            }

            IEnumerable<Video> allVideos = jsonProcessor.GetAllVideosFromJsonAsObjects(convertedJson);

            Console.WriteLine("\nAll video objects as strings:");
            foreach (var video in allVideos)
            {
                Console.WriteLine(video);
            }

            HtmlCreator htmlCreator = new HtmlCreator();
            string rssHtmlOutputFilePath = "../../../TelerikAcademyRss.html";

            htmlCreator.CreateHtmlPageFromVideoObjects(allVideos, rssHtmlOutputFilePath);

            Console.WriteLine("\nCreated file: {0}", rssHtmlOutputFilePath);
        }
    }
}

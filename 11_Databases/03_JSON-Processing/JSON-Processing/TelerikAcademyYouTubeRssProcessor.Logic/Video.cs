namespace TelerikAcademyYouTubeRssProcessor.Logic
{
    using Newtonsoft.Json;

    public class Video
    {
        public Video(string id, VideoLink link, string title)
        {
            this.Id = id;
            this.Link = link;
            this.Title = title;
        }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        public VideoLink Link { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            string stringRepresentation = $"Title: {this.Title}\nSource: {this.Link.Href}\nVideo Id: {this.Id}";
            return stringRepresentation;
        }
    }
}

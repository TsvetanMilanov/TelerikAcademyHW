namespace TelerikAcademyYouTubeRssProcessor.Logic
{
    using Newtonsoft.Json;

    public class VideoLink
    {
        [JsonProperty("@href")]
        public string Href { get; set; }

        public string Rel { get; set; }
    }
}
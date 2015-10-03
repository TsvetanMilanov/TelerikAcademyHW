namespace TelerikAcademyYouTubeRssProcessor.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JsonProcessor
    {
        public string ParseXmlToJson(string inputFilePath)
        {
            XDocument inputFileContent = XDocument.Load(inputFilePath);

            string parsedJson = JsonConvert.SerializeXNode(inputFileContent, Formatting.Indented);

            return parsedJson;
        }

        public IEnumerable<string> GetVideoTitlesFromJson(string json)
        {
            IEnumerable<string> titles = new List<string>();

            JObject jsonObject = JObject.Parse(json);

            titles = jsonObject["feed"]["entry"]
                .Select(entry => entry["title"].Value<string>()).ToList<string>();

            return titles;
        }

        public IEnumerable<Video> GetAllVideosFromJsonAsObjects(string json)
        {
            IEnumerable<Video> videos = new List<Video>();

            JObject jsonObject = JObject.Parse(json);

            videos = jsonObject["feed"]["entry"].Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString())).ToList<Video>();

            return videos;
        }
    }
}

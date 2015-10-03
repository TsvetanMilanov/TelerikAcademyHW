namespace TelerikAcademyYouTubeRssProcessor.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HtmlCreator
    {
        public void CreateHtmlPageFromVideoObjects(IEnumerable<Video> videos, string outputFilePath)
        {
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            File.AppendAllText(outputFilePath, this.CreateHtmlStringFromVideoObjects(videos, outputFilePath));
        }

        private string CreateHtmlStringFromVideoObjects(IEnumerable<Video> videos, string outputFilePath)
        {
            StringBuilder htmlOutput = new StringBuilder();
            htmlOutput.AppendLine("<!DOCTYPE html>");
            htmlOutput.AppendLine("<html>");
            htmlOutput.AppendLine("<head>");
            htmlOutput.AppendLine("<title>");
            htmlOutput.AppendLine("Telerik Academy YouTube RSS Feed");
            htmlOutput.AppendLine("</title>");
            htmlOutput.AppendLine("</head>");
            htmlOutput.AppendLine("<body>");

            foreach (var video in videos)
            {
                string currentCideoHolder = this.CreateVideoHolderForVideo(video);

                htmlOutput.AppendLine(currentCideoHolder);
            }

            htmlOutput.AppendLine("</body>");
            htmlOutput.AppendLine("</html>");

            return htmlOutput.ToString();
        }

        private string CreateVideoHolderForVideo(Video video)
        {
            StringBuilder videoHolder = new StringBuilder();

            videoHolder.AppendLine("<div>");
            videoHolder.AppendLine($"<a href=\"{video.Link.Href}\">{video.Title}</a>");
            videoHolder.AppendLine("<br />");
            videoHolder.AppendLine($"<iframe src=\"http://youtube.com/embed/{video.Id}?autoplay=false\"></iframe>");
            videoHolder.AppendLine("</div>");

            return videoHolder.ToString();
        }
    }
}

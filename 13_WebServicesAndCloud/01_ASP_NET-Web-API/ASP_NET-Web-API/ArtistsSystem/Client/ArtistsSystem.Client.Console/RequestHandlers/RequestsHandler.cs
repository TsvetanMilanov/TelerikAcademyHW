namespace ArtistsSystem.Client.Console.RequestHandlers
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;

    public class RequestsHandler : IRequestsHandler
    {
        public RequestsHandler(string baseUri, string serviceName, HttpClient httpClient, string contentType)
        {
            this.Uri = baseUri + "/api/" + serviceName;
            this.HttpClient = httpClient;
            this.ContentType = contentType;
        }

        protected string ContentType { get; set; }

        protected string Uri { get; set; }

        protected HttpClient HttpClient { get; set; }

        public string Get()
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), this.Uri);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(this.ContentType));

            string result = this.HttpClient
                .SendAsync(request)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            return result;
        }

        public string GetById(int id)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), this.Uri + "/" + id);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(this.ContentType));

            string result = this.HttpClient
                .SendAsync(request)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            return result;
        }

        public string Post(string data)
        {
            string result = this.HttpClient
                .PostAsync(this.Uri, new StringContent(data, Encoding.UTF8, this.ContentType))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            return result;
        }

        public string Put(int id, string data)
        {
            string result = this.HttpClient
                .PutAsync(this.Uri + "/" + id, new StringContent(data, Encoding.UTF8, this.ContentType))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            return result;
        }

        public void Delete(int id)
        {
            this.HttpClient.DeleteAsync(this.Uri + "/" + id);
        }
    }
}

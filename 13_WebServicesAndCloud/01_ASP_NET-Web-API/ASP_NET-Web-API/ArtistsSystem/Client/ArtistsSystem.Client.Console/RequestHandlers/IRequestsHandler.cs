namespace ArtistsSystem.Client.Console.RequestHandlers
{
    public interface IRequestsHandler
    {
        void Delete(int id);

        string Get();

        string GetById(int id);

        string Post(string data);

        string Put(int id, string data);
    }
}
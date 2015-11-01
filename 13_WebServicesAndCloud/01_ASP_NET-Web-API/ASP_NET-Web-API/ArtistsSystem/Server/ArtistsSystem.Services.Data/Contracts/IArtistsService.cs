namespace ArtistsSystem.Services.Data.Contracts
{
    using System.Linq;

    using Models;

    public interface IArtistsService
    {
        IQueryable<Artist> All();

        IQueryable<Artist> GetById(int id);

        Artist Add(Artist artist);

        Artist Update(int id, Artist artist);

        void Delete(int id);
    }
}

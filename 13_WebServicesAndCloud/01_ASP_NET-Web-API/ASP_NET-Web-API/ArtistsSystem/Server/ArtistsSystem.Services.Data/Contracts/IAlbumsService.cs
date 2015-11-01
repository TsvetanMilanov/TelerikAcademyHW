namespace ArtistsSystem.Services.Data.Contracts
{
    using System.Linq;

    using Models;

    public interface IAlbumsService
    {
        IQueryable<Album> All();

        IQueryable<Album> GetById(int id);

        Album Add(Album album);

        Album Update(int id, Album album);

        void Delete(int id);
    }
}

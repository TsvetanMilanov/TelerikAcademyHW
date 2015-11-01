namespace ArtistsSystem.Services.Data.Contracts
{
    using System.Linq;

    using Models;

    public interface ISongsService
    {
        IQueryable<Song> All();

        IQueryable<Song> GetById(int id);

        Song Add(Song song);

        Song Update(int id, Song song);

        void Delete(int id);
    }
}

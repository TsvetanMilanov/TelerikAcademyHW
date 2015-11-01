namespace ArtistsSystem.Services.Data
{
    using System;
    using System.Linq;

    using ArtistsSystem.Data.Repositories;
    using Contracts;
    using Models;

    public class AlbumsService : IAlbumsService
    {
        private IGenericRepository<Album> albums;

        public AlbumsService(IGenericRepository<Album> albums)
        {
            this.albums = albums;
        }

        public Album Add(Album album)
        {
            album = this.albums.Add(album);
            this.albums.SaveChanges();

            return album;
        }

        public IQueryable<Album> All()
        {
            return this.albums.All();
        }

        public void Delete(int id)
        {
            var album = this.GetById(id).FirstOrDefault();
            this.albums.Delete(album);
            this.albums.SaveChanges();
        }

        public IQueryable<Album> GetById(int id)
        {
            return this.albums.SearchFor(a => a.Id == id);
        }

        public Album Update(int id, Album album)
        {
            var albumToUpdate = this.GetById(id).FirstOrDefault();

            albumToUpdate.Title = album.Title ?? albumToUpdate.Title;
            albumToUpdate.Producer = album.Producer ?? albumToUpdate.Producer;
            albumToUpdate.Year = album.Year != default(int) ? album.Year : albumToUpdate.Year;

            this.albums.Update(albumToUpdate);
            this.albums.SaveChanges();

            return albumToUpdate;
        }
    }
}

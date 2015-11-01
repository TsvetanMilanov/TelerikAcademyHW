namespace ArtistsSystem.Services.Data
{
    using System;
    using System.Linq;

    using ArtistsSystem.Data.Repositories;
    using Contracts;
    using Models;

    public class SongsService : ISongsService
    {
        private IGenericRepository<Song> songs;

        public SongsService(IGenericRepository<Song> songs)
        {
            this.songs = songs;
        }

        public Song Add(Song song)
        {
            song = this.songs.Add(song);
            this.songs.SaveChanges();

            return song;
        }

        public IQueryable<Song> All()
        {
            return this.songs.All();
        }

        public void Delete(int id)
        {
            var song = this.GetById(id).FirstOrDefault();

            this.songs.Delete(song);
            this.songs.SaveChanges();
        }

        public IQueryable<Song> GetById(int id)
        {
            return this.songs.SearchFor(s => s.Id == id);
        }

        public Song Update(int id, Song song)
        {
            var songToUpdate = this.GetById(id).FirstOrDefault();

            songToUpdate.Album = song.Album ?? songToUpdate.Album;
            songToUpdate.Artist = song.Artist ?? songToUpdate.Artist;
            songToUpdate.Title = song.Title ?? songToUpdate.Title;
            songToUpdate.Year = song.Year != default(int) ? song.Year : songToUpdate.Year;

            this.songs.Update(songToUpdate);
            this.songs.SaveChanges();

            return songToUpdate;
        }
    }
}

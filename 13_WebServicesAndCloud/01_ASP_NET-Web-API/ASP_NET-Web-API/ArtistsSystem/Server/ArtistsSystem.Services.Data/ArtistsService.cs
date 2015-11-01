namespace ArtistsSystem.Services.Data
{
    using System;
    using System.Linq;

    using ArtistsSystem.Data;
    using ArtistsSystem.Data.Repositories;
    using Contracts;
    using Models;

    public class ArtistsService : IArtistsService
    {
        private IGenericRepository<Artist> artists;

        public ArtistsService(IGenericRepository<Artist> artists)
        {
            this.artists = artists;
        }

        public Artist Add(Artist artist)
        {
            if (artist.DateOfBirth == default(DateTime))
            {
                artist.DateOfBirth = DateTime.Now.AddYears(-30);
            }

            if (artist.CountryId == default(int))
            {
                artist.CountryId = 1;
            }

            artist = this.artists.Add(artist);
            this.artists.SaveChanges();

            return artist;
        }

        public IQueryable<Artist> All()
        {
            return this.artists.All();
        }

        public void Delete(int id)
        {
            var artistToDelete = this.GetById(id).FirstOrDefault();

            this.artists.Delete(artistToDelete);
            this.artists.SaveChanges();
        }

        public IQueryable<Artist> GetById(int id)
        {
            return this.artists
                .SearchFor(a => a.Id == id);
        }

        public Artist Update(int id, Artist artist)
        {
            var artistToUpdate = this.GetById(id).FirstOrDefault();

            artistToUpdate.Name = artist.Name ?? artistToUpdate.Name;
            artistToUpdate.DateOfBirth = artist.DateOfBirth != default(DateTime) ? artist.DateOfBirth : artistToUpdate.DateOfBirth;
            artistToUpdate.Country = artist.Country ?? artistToUpdate.Country;

            artistToUpdate = this.artists.Update(artistToUpdate);
            this.artists.SaveChanges();

            return artist;
        }
    }
}

namespace ArtistsSystem.DataImporter.Importers
{
    using System;
    using System.Linq;

    using Data;
    using Models;

    public class ArtistsImporter : DataImporter
    {
        public override void ImportData(IArtistsSystemDbContext database)
        {
            var countriesIds = database.Countries
                .OrderBy(c => Guid.NewGuid())
                .Select(c => c.Id)
                .ToList();

            var songs = database.Songs
                .OrderBy(s => Guid.NewGuid())
                .ToList();

            var firstArtist = new Artist
            {
                Name = "Angerfist",
                DateOfBirth = DateTime.Now.AddYears(-40),
                CountryId = countriesIds[0]
            };

            var secondArtist = new Artist
            {
                Name = "Bro Safari",
                DateOfBirth = DateTime.Now.AddYears(-30),
                CountryId = countriesIds[1]
            };

            var thirdArtist = new Artist
            {
                Name = "Skrilex",
                DateOfBirth = DateTime.Now.AddYears(-25),
                CountryId = countriesIds[0]
            };

            database.Artists.Add(firstArtist);
            database.Artists.Add(secondArtist);
            database.Artists.Add(thirdArtist);

            database.SaveChanges();
        }
    }
}

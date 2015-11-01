namespace ArtistsSystem.DataImporter.Importers
{
    using System;
    using System.Linq;

    using Data;
    using Models;

    public class AlbumsImporter : DataImporter
    {
        public override void ImportData(IArtistsSystemDbContext database)
        {
            var artists = database.Artists
                .OrderBy(a => Guid.NewGuid())
                .ToList();

            var producersIds = database.Producers
                .OrderBy(p => Guid.NewGuid())
                .Select(p => p.Id)
                .ToList();

            var songs = database.Songs
                .OrderBy(s => Guid.NewGuid())
                .ToList();

            var firstAlbum = new Album
            {
                Title = "First Album Title",
                ProducerId = producersIds[0],
                Year = DateTime.Now.AddYears(-2).Year
            };

            var secondAlbum = new Album
            {
                Title = "Second Album Title",
                ProducerId = producersIds[1],
                Year = DateTime.Now.AddYears(-1).Year
            };

            var thirdAlbum = new Album
            {
                Title = "Third Album Title",
                ProducerId = producersIds[2],
                Year = DateTime.Now.Year
            };

            database.Albums.Add(firstAlbum);
            database.Albums.Add(secondAlbum);
            database.Albums.Add(thirdAlbum);

            database.SaveChanges();
        }
    }
}

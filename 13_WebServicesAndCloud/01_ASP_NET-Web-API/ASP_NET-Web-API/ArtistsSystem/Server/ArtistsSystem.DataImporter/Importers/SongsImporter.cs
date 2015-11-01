namespace ArtistsSystem.DataImporter.Importers
{
    using System;
    using System.Linq;

    using Data;
    using Models;

    public class SongsImporter : DataImporter
    {
        private const int NumberOfSongsToAdd = 100;
        private const int NumberOfGenres = 3;
        private const string DefaultSongName = "Song Title #";

        public override void ImportData(IArtistsSystemDbContext database)
        {
            var albums = database.Albums
                .OrderBy(a => Guid.NewGuid())
                .ToList();

            var artists = database.Artists
                .OrderBy(a => Guid.NewGuid())
                .ToList();

            Random random = new Random();

            for (int i = 0; i < NumberOfSongsToAdd; i++)
            {
                var artistToAdd = artists[random.Next(0, artists.Count)];
                var albumToAdd = albums[random.Next(0, albums.Count)];
                artistToAdd.Albums.Add(albumToAdd);

                var songToAdd = new Song
                {
                    Title = DefaultSongName + i,
                    Year = DateTime.Now.AddYears(-(i % 7)).Year,
                    Genre = (Genre)(i % NumberOfGenres),
                    Artist = artistToAdd,
                    Album = albumToAdd
                };

                database.Songs.Add(songToAdd);
            }

            database.SaveChanges();
        }
    }
}

namespace ArtistsSystem.Api.Models.Songs
{
    public class SongRequestModel
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public int AlbumId { get; set; }

        public int ArtistId { get; set; }
    }
}
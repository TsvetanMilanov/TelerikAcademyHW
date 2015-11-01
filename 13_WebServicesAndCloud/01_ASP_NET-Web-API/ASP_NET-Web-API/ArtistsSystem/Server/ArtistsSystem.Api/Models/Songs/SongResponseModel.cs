namespace ArtistsSystem.Api.Models.Songs
{
    public class SongResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }
    }
}
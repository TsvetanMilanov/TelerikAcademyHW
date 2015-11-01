namespace ArtistsSystem.Api.Models.Albums
{
    using System.Collections.Generic;

    public class AlbumResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public ICollection<string> Artists { get; set; }

        public ICollection<string> Songs { get; set; }
    }
}
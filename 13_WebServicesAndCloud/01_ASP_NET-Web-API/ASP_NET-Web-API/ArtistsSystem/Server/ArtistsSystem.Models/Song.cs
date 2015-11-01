namespace ArtistsSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int Id { get; set; }

        [MaxLength(70)]
        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public Genre Genre { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}

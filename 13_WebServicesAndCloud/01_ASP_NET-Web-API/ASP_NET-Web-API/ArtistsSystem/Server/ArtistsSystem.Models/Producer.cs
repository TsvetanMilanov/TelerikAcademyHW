namespace ArtistsSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        private ICollection<Album> albums;

        public Producer()
        {
            this.albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [MaxLength(35)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}

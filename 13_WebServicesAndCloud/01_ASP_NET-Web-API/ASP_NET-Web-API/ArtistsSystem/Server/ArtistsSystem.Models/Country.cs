namespace ArtistsSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        private ICollection<Artist> artists;

        public Country()
        {
            this.artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}

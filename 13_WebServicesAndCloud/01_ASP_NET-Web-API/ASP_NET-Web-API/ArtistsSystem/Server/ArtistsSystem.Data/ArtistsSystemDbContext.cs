namespace ArtistsSystem.Data
{
    using System;
    using System.Data.Entity;
    using Models;

    public class ArtistsSystemDbContext : DbContext, IArtistsSystemDbContext
    {
        public ArtistsSystemDbContext()
            : base("ArtistsSystem")
        {
        }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Producer> Producers { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }
    }
}
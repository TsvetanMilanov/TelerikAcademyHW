namespace ArtistsSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Models;

    public interface IArtistsSystemDbContext
    {
        IDbSet<Artist> Artists { get; set; }

        IDbSet<Album> Albums { get; set; }

        IDbSet<Song> Songs { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Producer> Producers { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}

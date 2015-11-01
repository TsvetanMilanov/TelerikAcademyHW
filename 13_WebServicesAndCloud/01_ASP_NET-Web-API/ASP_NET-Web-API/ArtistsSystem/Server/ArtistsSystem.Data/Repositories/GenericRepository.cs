namespace ArtistsSystem.Data.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public GenericRepository(IArtistsSystemDbContext db)
        {
            this.Database = db;
            this.Set = this.Database.Set<T>();
        }

        protected IArtistsSystemDbContext Database { get; set; }

        protected IDbSet<T> Set { get; set; }

        public T Add(T entity)
        {
            var entry = this.Database.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.Set.Add(entity);
            }

            return entity;
        }

        public IQueryable<T> All()
        {
            return this.Set.AsQueryable();
        }

        public T Attach(T entity)
        {
            this.Set.Attach(entity);

            return entity;
        }

        public void Delete(T entity)
        {
            var entry = this.Database.Entry(entity);

            if (entry.State == EntityState.Deleted)
            {
                this.Set.Attach(entity);
                this.Set.Remove(entity);
            }
            else
            {
                entry.State = EntityState.Deleted;
            }
        }

        public void Detach(T entity)
        {
            var entry = this.Database.Entry(entity);

            entry.State = EntityState.Detached;
        }

        public void Dispose()
        {
            this.Database.Dispose();
        }

        public int SaveChanges()
        {
            return this.Database.SaveChanges();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions)
        {
            return this.All().Where(conditions);
        }

        public T Update(T entity)
        {
            var entry = this.Database.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.Set.Attach(entity);
            }

            entry.State = EntityState.Modified;

            return entity;
        }
    }
}

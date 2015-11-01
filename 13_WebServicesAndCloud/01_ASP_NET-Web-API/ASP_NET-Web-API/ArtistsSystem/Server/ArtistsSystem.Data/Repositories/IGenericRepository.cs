namespace ArtistsSystem.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All();

        IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions);

        T Add(T entity);

        void Delete(T entity);

        T Update(T entity);

        T Attach(T entity);

        void Detach(T entity);

        int SaveChanges();
    }
}

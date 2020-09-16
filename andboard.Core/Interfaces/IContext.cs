using System;
using System.Linq;

namespace andboard.Core.Interfaces
{
    public interface IContext : IDisposable
    {
        void Add<T>(T entity) where T : class;
        IQueryable<T> Query<T>() where T : class;
        int SaveChanges();
        void Update<T>(T entity) where T : class;
    }
}

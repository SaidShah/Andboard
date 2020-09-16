using andboard.Core.Entities;
using andboard.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace andboard.Infrastructure.Data
{
    public class Context : DbContext, IContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) 
        {

        }

        public virtual DbSet<Bug> Bugs { get; set; }
        public virtual DbSet<FeatureItem> FeatureItems { get; set; }
        public virtual DbSet<CustomerProject> CustomerProjects { get; set; }

        public void Add<T>(T entity) where T : class => base.Add(entity);

        public IQueryable<T> Query<T>() where T : class => base.Set<T>();

        public void Update<T>(T entity) where T : class
        {
            var set = base.Set<T>();

            if(!set.Local.Any(e => e == entity))
            {
                set.Attach(entity);
            }
        }
    }
}

using andboard.Core.Entities;
using System.Linq;

namespace andboard.Core.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IResult<T> FindById(long id);

        IResult<IQueryable<T>> FindAll();

        IResult<T> Create(T obj);

        IResult<T> Update(T obj);
    }
}

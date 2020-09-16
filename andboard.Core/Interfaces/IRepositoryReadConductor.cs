using andboard.Core.Entities;
using System.Linq;

namespace andboard.Core.Interfaces
{
    public interface IRepositoryReadConductor<T> where T : Entity
    {
        IResult<IQueryable<T>> FindAll();
        IResult<T> FindById(long id);
    }
}

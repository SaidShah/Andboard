using andboard.Core.Entities;

namespace andboard.Core.Interfaces
{
    public interface IRepositoryUpdateConductor<T> where T : Entity
    {
        IResult<T> Update(T obj);
    }
}

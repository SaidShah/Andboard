using andboard.Core.Entities;

namespace andboard.Core.Interfaces
{
    public interface IRepositoryCreateConductor<T> where T : Entity
    {
        IResult<T> Create(T obj);
    }
}

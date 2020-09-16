using andboard.Core.Entities;
using andboard.Core.Interfaces;

namespace andboard.Core.Conductors
{
    public class RepositoryCreateConductor<T> : IRepositoryCreateConductor<T> where T : Entity
    {
        IRepository<T> _repository;

        public RepositoryCreateConductor(IRepository<T> repository)
        {
            _repository = repository;
        }
        public IResult<T> Create(T obj)
        {
            var created = _repository.Create(obj);
            return created;
        }
    }
}

using andboard.Core.Entities;
using andboard.Core.Interfaces;

namespace andboard.Core.Conductors
{
    public class RepositoryUpdateConductor<T> : IRepositoryUpdateConductor<T> where T : Entity
    {
        private IRepository<T> _repository;

        public RepositoryUpdateConductor(IRepository<T> repository)
        {
            _repository = repository;
        }
        public IResult<T> Update(T obj)
        {
            var result = _repository.Update(obj);
            return result;
        }
    }
}

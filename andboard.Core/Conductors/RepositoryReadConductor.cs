using andboard.Core.Entities;
using andboard.Core.Interfaces;
using System.Linq;

namespace andboard.Core.Conductors
{
    public class RepositoryReadConductor<T> : IRepositoryReadConductor<T> where T : Entity
    {
        private IRepository<T> _repository;

        public RepositoryReadConductor(IRepository<T> repository)
        {
            _repository = repository;
        }
        public IResult<IQueryable<T>> FindAll()
        {
            var result = _repository.FindAll();
            if(result == null)
            {
                result.HasErrors = true;
                result.ResultObject = null;
            }
            return result;
        }

        public IResult<T> FindById(long id)
        {
            var result = _repository.FindById(id);
            if(result == null)
            {
                result.HasErrors = true;
                result.ResultObject = null;
            }

            return result;
        }
    }
}

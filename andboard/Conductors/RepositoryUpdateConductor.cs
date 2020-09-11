using andboard.Entities;
using andboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Conductors
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

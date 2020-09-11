using andboard.Entities;
using andboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Conductors
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

using andboard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Interfaces
{
    public interface IRepositoryReadConductor<T> where T : Entity
    {
        IResult<IQueryable<T>> FindAll();
        IResult<T> FindById(long id);
    }
}

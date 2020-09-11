using andboard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IResult<T> FindById(long id);

        IResult<IQueryable<T>> FindAll();

        IResult<T> Create(T obj);

        IResult<T> Update(T obj);
    }
}

using andboard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Interfaces
{
    public interface IRepositoryCreateConductor<T> where T : Entity
    {
        IResult<T> Create(T obj);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Interfaces
{
    public interface IResult<T>
    {
        T ResultObject { get; set; }

        bool HasErrors { get; set; }
    }
}

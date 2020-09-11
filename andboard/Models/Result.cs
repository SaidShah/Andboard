using andboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace andboard.Models
{
    public class Result<T> : IResult<T>
    {
        public T ResultObject { get; set; }
        public bool HasErrors { get; set; }

        public Result() { }

        public Result(T resultObject)
        {
            ResultObject = resultObject;
        }

        public Result(T resultObject, bool hasErrors)
        {
            HasErrors = hasErrors;
            ResultObject = resultObject;
        }
    }
}

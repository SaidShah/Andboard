using andboard.Core.Interfaces;

namespace andboard.Core.Models
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

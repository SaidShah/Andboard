namespace andboard.Core.Interfaces
{
    public interface IResult<T>
    {
        T ResultObject { get; set; }

        bool HasErrors { get; set; }
    }
}

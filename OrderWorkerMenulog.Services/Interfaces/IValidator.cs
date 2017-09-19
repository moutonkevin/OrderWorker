namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface IValidator
    {
        void Validate<T>(T value);
    }
}

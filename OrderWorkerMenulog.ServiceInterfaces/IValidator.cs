namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface IValidator
    {
        void Validate<T>(T value);
    }
}

namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface IParser
    {
        T Parse<T>(string content) where T : class;
    }
}

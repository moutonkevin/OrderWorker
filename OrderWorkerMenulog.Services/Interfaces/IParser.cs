namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface IParser
    {
        T Parse<T>(string content) where T : class;
    }
}

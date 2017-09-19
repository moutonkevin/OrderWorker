namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface IProcessorErroring
    {
        void OnError<T>(T value);
    }
}

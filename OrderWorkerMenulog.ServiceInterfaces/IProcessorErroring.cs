namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface IProcessorErroring
    {
        void OnError<T>(T value);
    }
}

namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface ISaver
    {
        void Save<T>(T value);
    }
}

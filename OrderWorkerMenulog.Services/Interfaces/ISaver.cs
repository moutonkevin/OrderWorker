namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface ISaver
    {
        void Save<T>(T value);
    }
}

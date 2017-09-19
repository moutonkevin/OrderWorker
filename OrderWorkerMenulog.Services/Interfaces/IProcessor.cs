using System.Threading.Tasks;

namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface IProcessor
    {
        Task ProcessAsync<T>(T value);
    }
}

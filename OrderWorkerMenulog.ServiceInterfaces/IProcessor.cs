using System.Threading.Tasks;

namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface IProcessor
    {
        Task ProcessAsync<T>(T value);
    }
}

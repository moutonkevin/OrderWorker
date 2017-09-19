using System.Threading.Tasks;

namespace OrderWorkerMenulog.ServiceInterfaces
{
    public interface IPoller
    {
        Task<T> PollAsync<T>(string source) where T : class;
    }
}

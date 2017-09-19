using System.Threading.Tasks;

namespace OrderWorkerMenulog.Services.Interfaces
{
    public interface IPoller
    {
        Task<T> PollAsync<T>(string source) where T : class;
    }
}

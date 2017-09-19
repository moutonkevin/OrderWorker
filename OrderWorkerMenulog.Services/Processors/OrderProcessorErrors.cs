using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services.Processors
{
    public class OrderProcessorErrors : IProcessorErroring
    {
        public void OnError<T>(T value)
        {
            //push to error queue;
        }
    }
}

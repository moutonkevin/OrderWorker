using System.Threading;
using System.Threading.Tasks;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services
{
    public class OrderLooper : ILooper
    {
        private readonly IPoller _poller;
        private readonly ISettings _settings;
        private readonly IProcessor _processor;
        private const string LoopDelayMillisecondsSettingsName = "OrderProcessingQueueDelayMilliseconds";
        private const string OrderProcessingQueueSettingsName = "OrderProcessingQueueName";
        private bool _isLooping;

        public OrderLooper(IPoller poller, ISettings settings, IProcessor processor)
        {
            _poller = poller;
            _settings = settings;
            _processor = processor;
            _isLooping = false;
        }

        public void Start()
        {
            var queueName = _settings.GetValue(OrderProcessingQueueSettingsName);
            var loopDelayMilliseconds = int.Parse(_settings.GetValue(LoopDelayMillisecondsSettingsName));

            _isLooping = true;

            Task.Run(async () =>
            {
                await StartLooping(queueName, loopDelayMilliseconds);
            });
        }

        private async Task StartLooping(string queueName, int loopDelay)
        {
            while (_isLooping)
            {
                var order = await _poller.PollAsync<string>(queueName);

                await _processor.ProcessAsync(order);

                Thread.Sleep(loopDelay);
            }
        }

        public void Stop()
        {
            _isLooping = false;
        }
    }
}

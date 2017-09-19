using System;
using System.Threading.Tasks;
using Ninject;
using OrderWorkerMenulog.Models;
using OrderWorkerMenulog.Services.Exceptions;
using OrderWorkerMenulog.Services.Interfaces;
using OrderWorkerMenulog.Shared.Interfaces;

namespace OrderWorkerMenulog.Services.Processors
{
    public class OrderProcessor : IProcessor
    {
        private readonly IParser _parser;
        private readonly ISaver _saver;
        private readonly IValidator _validator;
        private readonly ILogger _logger;
        private readonly IProcessorErroring _errorWorker;

        public OrderProcessor(
            [Named("ordervalidator")] IValidator validator, 
            IParser parser,
            ISaver saver,
            ILogger logger, 
            IProcessorErroring errorWorker)
        {
            _parser = parser;
            _validator = validator;
            _saver = saver;
            _logger = logger;
            _errorWorker = errorWorker;
        }

        public async Task ProcessAsync<T>(T value)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Processing...");

                try
                {
                    var order = _parser.Parse<OrderModel>(value as string);
                    _validator.Validate(order);
                    _saver.Save(order);
                }
                catch (ParsingException parsingException)
                {
                    _logger.LogException(parsingException);
                    _errorWorker.OnError(value as string);
                }
                catch (ValidationException validationException)
                {
                    _logger.LogException(validationException);
                    _errorWorker.OnError(value as string);
                }
                catch (Exception exception)
                {
                    _logger.LogException(exception);
                    _errorWorker.OnError(value as string);
                }
            });
        }
    }
}

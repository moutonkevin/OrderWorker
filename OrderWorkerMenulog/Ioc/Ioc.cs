using Ninject;
using OrderWorkerMenulog.Services;
using OrderWorkerMenulog.Services.Interfaces;
using OrderWorkerMenulog.Services.Processors;
using OrderWorkerMenulog.Services.Validation;
using OrderWorkerMenulog.Shared.Interfaces;
using OrderWorkerMenulog.Shared.Logging;

namespace OrderWorkerMenulog.Ioc
{
    public class Ioc
    {
        public IKernel RegisterComponents()
        {
            var kernel = new StandardKernel();

            kernel.Bind<ILogger>().To<ConsoleLogger>();
            kernel.Bind<IPoller>().To<OrderPoller>();
            kernel.Bind<IProcessor>().To<OrderProcessor>();
            kernel.Bind<ISettings>().To<Settings>();
            kernel.Bind<ILooper>().To<OrderLooper>();
            kernel.Bind<IParser>().To<OrderParser>();
            kernel.Bind<ISaver>().To<OrderSaver>();
            kernel.Bind<IProcessorErroring>().To<OrderProcessorErrors>();
            kernel.Bind<IValidator>().To<OrderValidator>().Named("ordervalidator");
            kernel.Bind<IValidator>().To<OrderContentValidator>().Named("customercontentordervalidator");
            kernel.Bind<IValidator>().To<OrderCustomerAddressValidator>().Named("customeraddressordervalidator");
            kernel.Bind<IValidator>().To<OrderCustomerValidator>().Named("customerordervalidator");

            return kernel;
        }
    }
}

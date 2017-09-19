using System;
using Ninject;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog
{
    class Program
    {
        static void Main(string[] args)
        {
            var ioc = new Ioc.Ioc();
            var kernel = ioc.RegisterComponents();
            var looper = kernel.Get<ILooper>();

            looper.Start();

            Console.ReadKey();
        }
    }
}

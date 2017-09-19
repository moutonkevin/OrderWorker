using System;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services
{
    public class OrderSaver : ISaver
    {
        public void Save<T>(T value)
        {
            Console.WriteLine("Saving...");
        }
    }
}

using System;
using Newtonsoft.Json;
using OrderWorkerMenulog.Models;
using OrderWorkerMenulog.Services.Exceptions;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services
{
    public class OrderParser : IParser
    {
        public T Parse<T>(string content) where T : class
        {
            Console.WriteLine("Parsing...");

            try
            {
                return JsonConvert.DeserializeObject<OrderModel>(content) as T;
            }
            catch (Exception exception)
            {
                throw new ParsingException(exception.Message);
            }
        }
    }
}

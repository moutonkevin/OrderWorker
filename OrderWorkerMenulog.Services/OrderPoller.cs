using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OrderWorkerMenulog.Models;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services
{
    public class OrderPoller : IPoller
    {
        public async Task<T> PollAsync<T>(string source) where T : class
        {
            return await Task.Run(() =>
            {
                Console.WriteLine("Polling...");

                var order = new OrderModel
                {
                    Customer = new OrderCustomerModel()
                    {
                        CustomerId = 0,
                        Address = new OrderCustomerAddressModel()
                        {
                            AddressLine1 = "dfsa",
                            AddressLine2 = "fdf",
                            City = "dsf"
                        }
                    },
                    OrderId = "DHWUFDS"
                };
                return JsonConvert.SerializeObject(order) as T;
            });
        }
    }
}

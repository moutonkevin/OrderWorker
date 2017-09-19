using OrderWorkerMenulog.Models;
using OrderWorkerMenulog.Services.Exceptions;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services.Validation
{
    public class OrderCustomerValidator : IValidator
    {
        public void Validate<T>(T value)
        {
            var order = value as OrderModel;
            var customerInfo = order.Customer;

            if (customerInfo.CustomerId == 0)
            {
                throw new ValidationException("CustomerId cannot be 0");
            }
        }
    }
}

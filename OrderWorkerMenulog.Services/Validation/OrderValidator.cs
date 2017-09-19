using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using OrderWorkerMenulog.Services.Exceptions;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services.Validation
{
    public class OrderValidator : IValidator
    {
        private readonly IEnumerable<IValidator> _validators;

        public OrderValidator(
            [Named("customercontentordervalidator")] IValidator contentValidator,
            [Named("customeraddressordervalidator")] IValidator addressValidator,
            [Named("customerordervalidator")] IValidator customerValidator)
        {
            _validators = new List<IValidator>
            {
                contentValidator,
                addressValidator,
                customerValidator
            };
        }

        public void Validate<T>(T value)
        {
            Console.WriteLine("Validating...");

            try
            {
                _validators.ToList().ForEach(validator => validator.Validate(value));
            }
            catch (ValidationException validationException)
            {
                throw new ValidationException(validationException.Message);
            }
            catch (Exception e)
            {
                throw new ValidationException(e.Message);
            }
        }
    }
}

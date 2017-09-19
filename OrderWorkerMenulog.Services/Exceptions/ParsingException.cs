using System;

namespace OrderWorkerMenulog.Services.Exceptions
{
    public class ParsingException : Exception
    {
        public ParsingException(string message) : base(message)
        {
            
        }
    }
}

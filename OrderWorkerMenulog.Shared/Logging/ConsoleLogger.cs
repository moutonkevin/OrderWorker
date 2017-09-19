using System;
using OrderWorkerMenulog.Shared.Interfaces;

namespace OrderWorkerMenulog.Shared.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

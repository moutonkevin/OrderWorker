using System;

namespace OrderWorkerMenulog.Shared.Interfaces
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogException(Exception exception);
    }
}

using System;
using NLog;
using ILogger = OrderWorkerMenulog.Shared.Interfaces.ILogger;

namespace OrderWorkerMenulog.Shared.Logging
{
    public class NLogLoggerAdapter : ILogger
    {
        private readonly NLog.ILogger _nlogLogger = LogManager.GetCurrentClassLogger();

        public void LogMessage(string message)
        {
            _nlogLogger.Log(LogLevel.Info, message);
        }

        public void LogException(Exception exception)
        {
            _nlogLogger.Log(LogLevel.Error, exception);
        }
    }
}

using System.Configuration;
using OrderWorkerMenulog.Services.Interfaces;

namespace OrderWorkerMenulog.Services
{
    public class Settings : ISettings
    {
        public string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}

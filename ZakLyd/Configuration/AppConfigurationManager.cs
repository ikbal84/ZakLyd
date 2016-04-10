using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ZakLyd.Caching;
using ZakLyd.Infrastructure.DAL;
using ZakLyd.Infrastructure.Repositories;

namespace ZakLyd.Configuration
{
    public class AppConfigurationManager
    {
        private readonly ConfigurationRepository _configurationRepo;

        public AppConfigurationManager()
        {
            _configurationRepo = new ConfigurationRepository();
        }

        public string GetConfigurationValueByKey(string key)
        {
            var configurationValue = _configurationRepo.GetConfigurationByKey(key);
            if (string.IsNullOrEmpty(configurationValue))
            {
                configurationValue = ConfigurationManager.AppSettings[key];
            }

            return configurationValue ?? string.Empty;
        }

        public IDictionary<string, string> GetConfigurationValuesByFamily(string family)
        {
            var configurationValues =_configurationRepo.GetConfigurationByFamilly(family);

            return !configurationValues.Any() ? null : configurationValues;
        }

        public IDictionary<string, string> GetLabelsByFamily(string labelFamily, string culture)
        {
            //get Configuration from DataBase
            return _configurationRepo.GetLabelsByFamily(labelFamily, culture);
        }

        public IDictionary<string, string> GetConfigurations()
        {
            return _configurationRepo.GetAllConfigurations();
        }


        public string GetConfigurationValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public IDictionary<string, string> GetConfigurationFromFile(string family)
        {
            var configKeys =
                ConfigurationManager.AppSettings.AllKeys.Where(k => k.ToLower().StartsWith(family.ToLower()));
            IDictionary<string, string> configValues = new Dictionary<string, string>();
            foreach (var k in configKeys)
            {
                configValues.Add(k, ConfigurationManager.AppSettings[k]);
            }

            return configValues;
        }

    }
}
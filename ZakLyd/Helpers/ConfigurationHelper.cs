using System.Collections.Generic;
using System.Linq;
using ZakLyd.Caching;
using ZakLyd.Configuration;

namespace ZakLyd.Helpers
{
    public static class ConfigurationHelper
    {
        private static readonly CacheManager CacheManager = new CacheManager();
        private static readonly AppConfigurationManager ConfigurationManager = new AppConfigurationManager();

        public static string GetConfigurationValueByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return string.Empty;
            }

            var confValue = CacheManager.GetCache(key);

            if (confValue != null) return confValue.ToString();

            
            var configs = ConfigurationManager.GetConfigurations();

            string configValue;

            return configs.TryGetValue(key, out configValue) ? configValue : null;
        }


        public static IDictionary<string, string> GetConfigurationValuesByfamily(string family)
        {
            if (string.IsNullOrEmpty(family))
            {
                return null;
            }

            var confValues = CacheManager.GetCacheForFamilly(family);

            if (confValues != null) return confValues.ToDictionary(c => c.Key, c => (string)c.Value);

            var confValuesFromRepo = ConfigurationManager.GetConfigurationValuesByFamily(family);

            if (confValuesFromRepo == null) return null;

            CacheManager.SetCache(confValuesFromRepo);

            return confValuesFromRepo;
        }

    }
}
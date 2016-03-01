using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZakLyd.Caching;
using ZakLyd.Configuration;

namespace ZakLyd.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetConfigurationValueByKey(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                return String.Empty;
            }

            CacheManager cacheManager = new CacheManager();

            var confValue = cacheManager.GetCache(key);
            
            if (confValue== null)
            {
                ConfigurationManager confManager = new ConfigurationManager();
                var configs = confManager.GetConfigurations();

                string configValue = String.Empty;
                configs.TryGetValue(key, out configValue);
                return configValue;
            }
            else
            {
                return confValue.ToString();
            }


        }
    }
}
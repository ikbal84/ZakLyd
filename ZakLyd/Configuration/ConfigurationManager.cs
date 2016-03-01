using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZakLyd.Caching;
using ZakLyd.Infrastructure.DAL;
using ZakLyd.Infrastructure.Repositories;

namespace ZakLyd.Configuration
{
    public class ConfigurationManager
    {
        
        private ConfigurationRepository _configurationRepo;

        public ConfigurationManager()
        {
            _configurationRepo = new ConfigurationRepository();
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

        private void CachItem(string key, string value)
        {
            CacheManager cacheMger = new CacheManager();
            cacheMger.SetCache(key, value);
        }

        private void CachItems(IDictionary<string,string> Items)
        {
            CacheManager cacheMger = new CacheManager();
            cacheMger.SetCache(Items);
        }
    }
}
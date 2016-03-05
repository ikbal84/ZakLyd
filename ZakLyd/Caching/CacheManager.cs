using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;

namespace ZakLyd.Caching
{
    public class CacheManager
    {
        private MemoryCache _cache = MemoryCache.Default;
        public object GetCache(string key)
        {
            return _cache[key];
        }

        public void SetCache(string key, Object value, int cacheTime = 1500)
        {
            _cache.Add(new CacheItem(key, value), SetCachePolicy());
        }

        public void SetCache(IDictionary<string,string> keyValues)
        {
            var cachPolicy = SetCachePolicy();
            foreach (KeyValuePair<string,string> kv in keyValues)
            {
                _cache.Add(new CacheItem(kv.Key, kv.Value), cachPolicy);
            }
        }

        public Tuple<bool,string> Flush()
        {
            try
            {
                _cache.Dispose();
                return Tuple.Create<bool, string>(true, string.Empty);
            }
            catch(Exception e)
            {
                return Tuple.Create<bool, string>(false, e.Message);
            }
            
        }

        private CacheItemPolicy SetCachePolicy(int cacheTime = 1500)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            return policy;
        }
    }
}
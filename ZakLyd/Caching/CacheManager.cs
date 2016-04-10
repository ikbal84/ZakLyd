using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;

namespace ZakLyd.Caching
{
    public class CacheManager
    {
        private readonly MemoryCache _cache = MemoryCache.Default;

        public object GetCache(string key)
        {
            return _cache[key];
        }

        public IDictionary<string, object> GetCacheForFamilly(string familly)
        {
            var result = _cache.Where(cache => cache.Key.ToLower().StartsWith(familly.ToLower()));

            return result.Any() ? result.ToDictionary(c => c.Key, c=> c.Value) : null;
        }

        public void SetCache(string key, object value, int cacheTime = 1500)
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
                return Tuple.Create(true, string.Empty);
            }
            catch(Exception e)
            {
                return Tuple.Create(false, e.Message);
            }
            
        }

        private CacheItemPolicy SetCachePolicy(int cacheTime = 1500)
        {
            return new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime)
            };
        }
    }
}
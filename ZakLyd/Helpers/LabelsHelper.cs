using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using ZakLyd.Caching;
using ZakLyd.Configuration;
using ZakLyd.Utils;

namespace ZakLyd.Helpers
{
    public static class LabelsHelper
    {
        public static string GetLabel(string labelKey, string culture)
        {
            if (String.IsNullOrEmpty(labelKey))
            {
                return String.Empty;
            }

            if (!labelKey.Contains("."))
            {
                return String.Empty;
            }

            CacheManager cacheManager = new CacheManager();

            var valueFromCache = cacheManager.GetCache(labelKey);

            if (valueFromCache == null)
            {
                ConfigurationManager confManager = new ConfigurationManager();
                string LabelFamily = labelKey.Split('.')[0];
                var familyLabels = confManager.GetLabelsByFamily(LabelFamily, culture);
            
                string labelValue = String.Empty;
                familyLabels.TryGetValue(labelKey, out labelValue);
                CacheManager cacheMger = new CacheManager();
                cacheMger.SetCache(familyLabels);
                return labelValue;
            }
            else
            {
                return valueFromCache.ToString();
            }

        }

    }
}
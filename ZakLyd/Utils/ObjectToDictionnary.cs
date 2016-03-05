using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ZakLyd.Utils
{
    public class ObjectToDictionnary
    {
        public  IDictionary<string, object> ObjectToDictionary<T>(T item) where T : class
        {
            if(item == null)
            {
                return null;
            }

            Type myObjectType = item.GetType();
            IDictionary<string, object> dict = new Dictionary<string, object>();
            var indexer = new object[0];
            PropertyInfo[] properties = myObjectType.GetProperties();
            foreach (var info in properties)
            {
                var value = info.GetValue(item, indexer);
                dict.Add(info.Name, value);
            }
            return dict;
        }
    }
}
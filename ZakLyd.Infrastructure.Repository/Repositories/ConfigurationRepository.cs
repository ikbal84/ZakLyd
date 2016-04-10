using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities.Configuration;
using ZakLyd.Infrastructure.DAL;

namespace ZakLyd.Infrastructure.Repositories
{
    public class ConfigurationRepository
    {
        public IDictionary<string, string> GetLabelsByFamily(string familyLabel, string culture)
        {
            var result = new Dictionary<string, string>();
            using (var _dbContext = new ZakLydContext())
            {
                result = _dbContext.LabelCulture
                            .Where(c => c.Culture.CultureValue == culture)
                            .Where(l => l.Lable.LabelKey.ToLower().StartsWith(familyLabel))
                            //.Select(l=> new { l.Lable.LabelKey, l.LabelValue })
                            .ToDictionary(k => k.Lable.LabelKey, k => k.LabelValue);
            }

            return result;
        }


        public string GetConfigurationByKey(string key)
        {
            IQueryable<Configuration> queryResult;

            using (var dbContext = new ZakLydContext())
            {
                queryResult =
                    dbContext.Configuration.Where(
                        c => c.ConfigurationKey.Equals(key, StringComparison.OrdinalIgnoreCase));
            }

            return queryResult.Any() ? queryResult.First().ConfigurationValue : string.Empty;
             
        }

        public IDictionary<string,string> GetConfigurationByFamilly(string family)
        {
            IQueryable<Configuration> queryResult;

            using (var dbContext = new ZakLydContext())
            {
                queryResult =
                    dbContext.Configuration.Where(
                        c => c.ConfigurationKey.ToLower().StartsWith(family.ToLower()));
            }

            return queryResult.Any() ? queryResult.ToDictionary(c=>c.ConfigurationKey, c=> c.ConfigurationValue) : null;
        }

        public IDictionary<string, string> GetAllConfigurations()
        {
            var result = new Dictionary<string, string>();

            using (var _dbContext = new ZakLydContext())
            {
                result = _dbContext.Configuration.ToDictionary(k => k.ConfigurationKey, k => k.ConfigurationValue);
            }

            return result;
        }

        public IList<string> GetAllCultures()
        {
            var result = new List<string>();

            using (var _dbContext = new ZakLydContext())
            {
                result = _dbContext.Culture.Select(c => c.CultureValue).ToList();
            }

            return result;
        }
    }
}

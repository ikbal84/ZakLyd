using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

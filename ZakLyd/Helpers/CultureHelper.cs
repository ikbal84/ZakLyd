using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZakLyd.Infrastructure.Repositories;

namespace ZakLyd.Helpers
{
    public class CultureHelper
    {
        public static bool ValidateCulture(string culture)
        {
            ConfigurationRepository configRepo = new ConfigurationRepository();
            return configRepo.GetAllCultures().Contains(culture);
        }
    }
}
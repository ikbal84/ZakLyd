using System;
using System.Collections.Generic;
using System.Linq;
using ZakLyd.Helpers;
using ZakLyd.Infrastructure.ElasticRepository;
using ZakLyd.Models;

namespace ZakLyd.Services
{
    public class ElasticService
    {
        private readonly ElasticRepository _elasticRepository;

        public ElasticService()
        {
            _elasticRepository = new ElasticRepository(GetElasticNodesFromConfiguration());
        }

        public IEnumerable<PromoModel> GetPromoList(int from, int size)
        {
            return _elasticRepository.GetPromotions(from, size);
        }

        private static IEnumerable<string> GetElasticNodesFromConfiguration()
        {
            var lst = new List<string>();
            var cond = lst.Where(s => s == "t");
            return ConfigurationHelper.GetConfigurationValuesByfamily("ElasticNodes").Select(c=> c.Value).ToList();

        } 
    }
}
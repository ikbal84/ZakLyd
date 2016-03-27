using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using ZakLyd.Web.InterfaceEntities;

namespace ZakLyd.Infrastructure.ElasticRepository.Types
{
    public class SearchResult<T> where T : InterfaceEntity
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ISearchResponse<T> Result { get; set; }
    }
}

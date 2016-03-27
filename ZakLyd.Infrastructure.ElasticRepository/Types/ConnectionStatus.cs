using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Infrastructure.ElasticRepository.Types
{
    public class ConnectionStatus
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}

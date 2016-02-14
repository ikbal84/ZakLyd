using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Agent
    {
        public long AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Agency Agency { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public AgentRole Role { get; set; }
    }
}

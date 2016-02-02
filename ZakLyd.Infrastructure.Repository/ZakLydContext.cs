using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities;

namespace ZakLyd.Infrastructure.Repository
{
    public class ZakLydContext : DbContext 
    {
        public ZakLydContext(): base("name=DBConnection")
        {

        }

        public DbSet<Agency> Agency { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Media> Media { get; set; }
    }
}

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
        public DbSet<AirPlaneInformation> AirPlaneInformation { get; set; }
        public DbSet<Announcment> Announcment { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelDetail> HotelDetail { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Step> Step { get; set; }
        public DbSet<Trip> Trip { get; set; }
    }
}

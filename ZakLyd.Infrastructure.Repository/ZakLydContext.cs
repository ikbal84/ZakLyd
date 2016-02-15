using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakLyd.Domaine.Entities;
using ZakLyd.Domaine.Entities.RefData;

namespace ZakLyd.Infrastructure.DAL
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
        public DbSet<Comment> Comment { get; set; }
        public DbSet<CommercialOffer> CommercialOffer { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<AgencyAccountHistory> AgencyAccountHistory { get; set; }

        //Reference tables
        public DbSet<TrefAgentRole> AgentRole { get; set; }
        public DbSet<TrefCommentStatus> CommentStatus { get; set; }
        public DbSet<TrefCommercialOfferType> CommercialOfferType { get; set; }
        public DbSet<TrefMediaType> MediaType { get; set; }
        public DbSet<TrefPropertyGroup> PropertyGroup { get; set; }
        public DbSet<TrefSubscriptionAction> SubscriptionAction { get; set; }
        public DbSet<TrefSubscriptionStatus> SubscriptionStatus { get; set; }
        public DbSet<TrefSubscriptionType> SubscriptionType { get; set; }
    }
}

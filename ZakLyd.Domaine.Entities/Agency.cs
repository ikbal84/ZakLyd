using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Domaine.Entities
{
    public class Agency
    {
        public Guid AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Fax3 { get; set; }
        public string Email1 {get; set;}
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public ICollection<Media> MediaList { get; set; }
        public ICollection<Announcment> AnnouncementList { get; set; }

    }
}

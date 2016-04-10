using Nest;

namespace ZakLyd.Web.InterfaceEntities
{
    public class InterfaceAddress
    {
        [Number(NumberType.Integer)]
        public long AddressId { get; set; }
        [String]
        public string AddressValue { get; set; }
        [String]
        public string PostalCode { get; set; }
        [String]
        public string City { get; set; }
        [Number(NumberType.Double)]
        public long Latitude { get; set; }
        [Number(NumberType.Double)]
        public long Longitude { get; set; }

    }
}
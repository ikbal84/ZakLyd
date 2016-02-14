using System;
using System.Collections.Generic;

namespace ZakLyd.Domaine.Entities
{
    public class AirPlaneInformation
    {
        public long AirPlaneInformationId { get; set; }
        public string AirPlaneInfoName { get; set; }
        public Trip Aller { get; set; }
        public Trip Retour { get; set; }
    }

}

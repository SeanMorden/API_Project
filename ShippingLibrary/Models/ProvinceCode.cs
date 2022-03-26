using System;
using System.Collections.Generic;

#nullable disable

namespace ShippingLibrary.Models
{
    public partial class ProvinceCode
    {
        public string Province { get; set; }
        public int ExpressEarlyZone { get; set; }
        public int ExpressZone { get; set; }
        public int ExpressSaverZone { get; set; }
        public int ExpeditedZone { get; set; }
        public int StandardZone { get; set; }

        public virtual DomesticExpedited ExpeditedZoneNavigation { get; set; }
        public virtual DomesticExpressEarly ExpressEarlyZoneNavigation { get; set; }
        public virtual DomesticExpressSaver ExpressSaverZoneNavigation { get; set; }
        public virtual DomesticExpress ExpressZoneNavigation { get; set; }
        public virtual DomesticStandard StandardZoneNavigation { get; set; }
    }
}

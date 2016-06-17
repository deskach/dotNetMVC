using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Abstract {
    public interface IShippingDetails {
        string Name {get; set; }

        string Line1 { get; set; }
        string Line2 { get; set; }

        string City { get; set; }

        string State { get; set; }
        string Zip { get; set; }

        string Country { get; set; }
        bool GiftWrap { get; set; }
    }
}

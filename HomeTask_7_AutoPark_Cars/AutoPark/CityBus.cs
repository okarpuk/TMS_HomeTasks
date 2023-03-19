using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_7_AutoPark_Cars.AutoPark
{
    public class CityBus : PublicTransport
    {
        public CityBus(string destination, string route, string departureTime, int seatsQty) : base(destination, route, departureTime, seatsQty, "Internal combustion engine")
        {
        }

        public override string TypeOfTransport()
        {
            return $"CityBus: this transport type equipped with {TransportType}";
        }
    }
}

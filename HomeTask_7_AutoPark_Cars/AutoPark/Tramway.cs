using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_7_AutoPark_Cars.AutoPark
{
    public class Tramway : PublicTransport
    {
        public Tramway(string destination, string route, string departureTime, int seatsQty) : base(destination, route, departureTime, seatsQty, "Uses rails")
        {
        }

        public override string TypeOfTransport()
        {
            return $"Tramway: this transport type {TransportType}";
        }
    }
}

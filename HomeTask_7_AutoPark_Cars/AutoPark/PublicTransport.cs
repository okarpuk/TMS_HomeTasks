using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_7_AutoPark_Cars.AutoPark
{
    public abstract class PublicTransport : SuperTransport, RoutesData
    {
        public string RouteNumber { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public int SeatsQTY { get; set; }
        public string TransportType { get; set; }

        public PublicTransport(string destination, string routeNumber, string departureTime, int seatsQty, string transportType)
        {
            RouteNumber = routeNumber;
            Destination = destination;
            DepartureTime = departureTime;
            SeatsQTY = seatsQty;
            TransportType = transportType;
        }

        public void TransportInfo()
        {
            Console.WriteLine($"Number of route: {RouteNumber}. Goes to {Destination}. Departure time: {DepartureTime}. Seats quantity: {SeatsQTY}");
        }

        public override string ToString()
        {
            return $"Type of transport: {TransportType}. Destination: {Destination}. Number of route: {RouteNumber}. Departure time: {DepartureTime}. Seats quantity: {SeatsQTY}";
        }
    }
}

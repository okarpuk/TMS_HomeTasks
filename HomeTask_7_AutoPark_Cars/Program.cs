using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HomeTask_7_AutoPark_Cars.AutoPark;

namespace HomeTask_7_AutoPark_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AUTOPARK
            //BUS
            CityBus cBus1 = new CityBus("Railway station", "3", "09:00", 30);
            cBus1.TransportInfo();
            Console.WriteLine(cBus1.TypeOfTransport());
            Console.WriteLine();
            //TROLLEY
            Trolleybus tBus1 = new Trolleybus("M-r West", "20", "10:00", 40);
            tBus1.TransportInfo();
            Console.WriteLine(tBus1.TypeOfTransport());
            Console.WriteLine();
            //TRAM
            Tramway tWay1 = new Tramway("Masherova", "41", "11:00", 50);
            tWay1.TransportInfo();
            Console.WriteLine(tWay1.TypeOfTransport());
            Console.WriteLine();
            //OBJECTS FOR ARRAY
            CityBus cBus2 = new CityBus("Gefest plant", "52", "12:00", 35);
            Trolleybus tBus2 = new Trolleybus("M-r North", "6", "13:00", 45);
            Tramway tWay2 = new Tramway("Pushkina", "17", "14:00", 55);
            //ARRAY
            PublicTransport[] allTransport = { cBus1, cBus2, tBus1, tBus2, tWay1, tWay2 };
            var orderBySeats = allTransport.OrderBy(seats => seats.SeatsQTY).ToArray();
            Array.ForEach(orderBySeats, Console.WriteLine);
            //ENTER DESTINATION AND TINE TO FIND TANSPORT
            Console.WriteLine("Enter destination");
            string? userDestination = Console.ReadLine();
            Console.WriteLine("Enter departure time in 00:00 format");
            string? userDepartureTime = Console.ReadLine();
            foreach (var searchRoute in allTransport)
            {
                if (searchRoute.DepartureTime == userDepartureTime || searchRoute.Destination == userDestination)
                {
                    Console.WriteLine(string.Format("{0}, {1}, {2}", searchRoute.RouteNumber, searchRoute.Destination, searchRoute.DepartureTime));
                }
            }
            //NEXT TRANSPORT
            Console.WriteLine("To find next routes enter one more departure time");
            string? userDepartureTime2 = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(userDepartureTime2);
            foreach (var searchRoute2 in allTransport)
            {
                if (DateTime.Parse(searchRoute2.DepartureTime) > dateTime)
                {
                    Console.WriteLine(string.Format("{0}, {1}, {2}", searchRoute2.RouteNumber, searchRoute2.Destination, searchRoute2.DepartureTime));
                }
            }



        }
    }
}
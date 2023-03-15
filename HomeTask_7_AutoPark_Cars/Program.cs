using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HomeTask_7_AutoPark_Cars.AutoPark;
using HomeTask_7_AutoPark_Cars.Cars;

namespace HomeTask_7_AutoPark_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
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
            */

            //CARS
            var bike1 = new Bike() { LicensePlate = "1111AA-1", Brand = "Java", MaxSpeed = 120, MaxLoad = 150 };
            var bike2 = new Bike() { LicensePlate = "2222AA-1", Brand = "Izh", MaxSpeed = 100, MaxLoad = 160 };
            var bike3 = new Bike() { LicensePlate = "3333AA-1", Brand = "Minsk", MaxSpeed = 110, MaxLoad = 300, SidecarIsAble = true };
            var passCar1 = new PassengerCar() { LicensePlate = "4444AA-1", Brand = "Geely", MaxSpeed = 160, MaxLoad = 500 };
            var passCar2 = new PassengerCar() { LicensePlate = "5555AA-1", Brand = "Audi", MaxSpeed = 180, MaxLoad = 600 };
            var passCar3 = new PassengerCar() { LicensePlate = "6666AA-1", Brand = "Mercedes", MaxSpeed = 210, MaxLoad = 700 };
            var freight1 = new FreightCar() { LicensePlate = "7777AA-1", Brand = "Volvo", MaxSpeed = 120, MaxLoad = 10000 };
            var freight2 = new FreightCar() { LicensePlate = "8888AA-1", Brand = "Scania", MaxSpeed = 140, MaxLoad = 12000 };
            var freight3 = new FreightCar() { LicensePlate = "9999AA-1", Brand = "Renault", MaxSpeed = 160, MaxLoad = 13000, TrailerIsAble = true };

            List<CarInfo> allVehicles = new List<CarInfo>()
            {
                bike1,
                bike2,
                bike3,
                passCar1,
                passCar2,
                passCar3,
                freight1,
                freight2,
                freight3
            };

            Console.WriteLine("All vehicles: ");
            foreach (var vehicle in allVehicles)
            {
                vehicle.PrintVehicleInfo();
            }
            Console.WriteLine();

            Console.WriteLine("Vehicle with maximum load more than 10000 is: ");
            var maxLoad = VehicleCapacity.VehicleFound(allVehicles, 10001);
            foreach (var vehicleMax in maxLoad)
            {
                vehicleMax.PrintVehicleInfo();
            }
        }
    }
}
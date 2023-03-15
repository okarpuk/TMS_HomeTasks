using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_7_AutoPark_Cars.Cars
{
    internal abstract class CarInfo
    {
        public string Brand { get; set; }
        public string LicensePlate { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxLoad { get; set; }

        public virtual void PrintVehicleInfo()
        {
            Console.WriteLine($"Vehicle Type: {this.GetType().Name}: , Brand: {Brand}, LicensePlate: {LicensePlate}, MaxSpeed: {MaxSpeed}, MaxLoad: {GetMaxLoad()}");
        }

        public abstract int GetMaxLoad();
    }
}

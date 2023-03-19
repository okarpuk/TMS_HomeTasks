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
    internal class FreightCar : CarInfo
    {
        public bool TrailerIsAble { get; set; }

        public override void PrintVehicleInfo()
        {
            base.PrintVehicleInfo();
            Console.WriteLine($"TrailerIsAble = {TrailerIsAble}");
        }

        public override int GetMaxLoad()
        {
            return TrailerIsAble ? this.MaxLoad * 2 : this.MaxLoad;
        }
    }
}

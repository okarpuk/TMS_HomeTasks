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
    internal class Bike : CarInfo
    {
        public bool SidecarIsAble { get; set; }

        public override void PrintVehicleInfo()
        {
            base.PrintVehicleInfo();
            Console.WriteLine($"SidecarIsAble = {SidecarIsAble}");
        }

        public override int GetMaxLoad()
        {
            return SidecarIsAble ? this.MaxLoad : 0;
        }
    }
}


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
    internal static class VehicleCapacity
    {
        public static IEnumerable<CarInfo> VehicleFound(IEnumerable<CarInfo> myVehicles, int givenLoad)
        {
            return from myVehicle in myVehicles
                   where myVehicle.MaxLoad > givenLoad
                   select myVehicle;
        }
    }
}

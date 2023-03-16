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
    internal class PassengerCar : CarInfo
    {
        public override int GetMaxLoad()
        {
            return this.MaxLoad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Cars
{
    internal class BenzineMotor : Motor
    {
        public override void myMotion() => Console.WriteLine("BENZINE CAR MOTION");
        
        public override void myRefuel() => Console.WriteLine("BENZINE CAR REFUEL");
    }
}

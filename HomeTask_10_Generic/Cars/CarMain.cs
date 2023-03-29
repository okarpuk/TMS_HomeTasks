using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Cars
{
    public class CarMain<T> where T : Motor
    {
        private T myMotor;

        public CarMain(T motor) => myMotor = motor;

        public void CarMotion() => myMotor.myMotion();

        public void CarRefuel() => myMotor.myRefuel();
    }
}

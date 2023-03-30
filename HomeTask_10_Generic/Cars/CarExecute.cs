using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Cars
{
    internal class CarExecute
    {
        static public void MyCars()
        {
            var dieselAuto = new CarMain<DieselMotor>(new DieselMotor());
            var electricalAuto = new CarMain<ElectricalMotor>(new ElectricalMotor());
            var benzineAuto = new CarMain<BenzineMotor>(new BenzineMotor());
            dieselAuto.CarMotion();
            dieselAuto.CarRefuel();
            electricalAuto.CarMotion();
            electricalAuto.CarRefuel();
            benzineAuto.CarMotion();
            benzineAuto.CarRefuel();
        }
    }
}

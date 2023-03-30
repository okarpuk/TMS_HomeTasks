using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask_10_Generic.Generic;
using HomeTask_10_Generic.Cars;
using HomeTask_10_Generic.Point;

namespace HomeTask_10_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK *GENERIC*");
            GenericExecute.MyGeneric();
            Console.WriteLine("\nTASK *CARS*");
            CarExecute.MyCars();
            Console.WriteLine("\nTASK *POINT*");
            PointExecute.MyPoint();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Point
{
    internal class PointExecute
    {
        static public void MyPoint()
        {
            Point<double> point1 = new Point<double>(7, 42);
            Point<double> point2 = new Point<double>(11, 99);
            point1.GetDistance(point1, point2);
        }
    }
}

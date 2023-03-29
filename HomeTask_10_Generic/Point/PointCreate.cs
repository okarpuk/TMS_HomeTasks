using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Point
{
    public class Point<T>
    {
        private T x;
        private T y;
        public T X
        {
            get => x;
        }
        public T Y
        {
            get => y;
        }
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public void GetDistance(Point<T> pointOne, Point<T> pointTwo)
        {
            double x1 = Convert.ToDouble(pointOne.x);
            double y1 = Convert.ToDouble(pointOne.y);
            double x2 = Convert.ToDouble(pointTwo.x);
            double y2 = Convert.ToDouble(pointTwo.y);
            var pointsDistance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine($"POINT #1:\nx={x1}, y={y1}\n\nPOINT #2:\nx={x2}, y={y2}\n\nPOINTS DISTANCE:\n{pointsDistance}");
        }
    }
}

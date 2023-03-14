using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class RectangleBuilder
    {
        public RectangleBuilder() { }
        public Rectangle CreateRectangle(double height, double width)
        {
            if (height == width)
            {
                return new Square(height, width);
            }
            return new Rectangle(height, width);
        }
    }
}

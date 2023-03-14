using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class Rectangle
    {
        public double height;
        public double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public virtual double GetSquare()
        {
            Console.WriteLine("Get rectangle square");
            return height * width;
        }
    }
}

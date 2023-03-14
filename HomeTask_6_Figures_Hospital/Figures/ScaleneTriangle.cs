using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class ScaleneTriangle : Triangle
    {
        public ScaleneTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get ScaleneTriangle square");
            double semiPerimetr = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get IsoscelesTriangle square");
            double height = Math.Sqrt(Math.Pow(firstSide, 2) - Math.Pow(thirdSide, 2) / 4);
            return height * (thirdSide / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }
        public override double GetSquare()
        {
            Console.WriteLine("Get RightTriangle square");
            if (firstSide > secondSide)
            {
                if (firstSide > thirdSide)
                {
                    return GetSquareForRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
            else
            {
                if (secondSide > thirdSide)
                {
                    return GetSquareForRightTriangle(firstSide, thirdSide);
                }
                else
                {
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
        }
        private double GetSquareForRightTriangle(double firstSide, double secondSide)
        {
            return 0.5 * firstSide * secondSide;
        }
    }
}

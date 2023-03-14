using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_Figures_Hospital.Figures
{
    public class TriangleBuilder
    {
        public TriangleBuilder() { }
        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            //Equiletarl
            if (firstSide == secondSide && firstSide == thirdSide)
            {
                return new EquiletarlTriangle(firstSide, secondSide, thirdSide);
            }
            //RightTriangle
            if (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            if (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            if (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            //Scalene
            else if (firstSide != secondSide && firstSide != thirdSide && secondSide != thirdSide)
            {
                return new ScaleneTriangle(firstSide, secondSide, thirdSide);
            }
            //Isosceles
            else if (firstSide == secondSide && firstSide != thirdSide)
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else if (firstSide == thirdSide && firstSide != secondSide)
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else if (secondSide == thirdSide && firstSide != secondSide)
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}

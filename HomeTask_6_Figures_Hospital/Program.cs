using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HomeTask_6_Figures_Hospital.Figures;

namespace HomeTask_6_Figures_Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIGURES
            //Triangle
            Console.WriteLine("TASK FIGURES");
            Triangle triangle1 = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Triangle triangle2 = new TriangleBuilder().CreateTriangle(6, 4, 6);
            Triangle triangle3 = new TriangleBuilder().CreateTriangle(6, 8, 10);
            Triangle triangle4 = new TriangleBuilder().CreateTriangle(5, 7, 10);
            //Rectangle
            Rectangle rectangle1 = new RectangleBuilder().CreateRectangle(5, 8);
            Rectangle rectangle2 = new RectangleBuilder().CreateRectangle(5, 5);
            //Arrays
            Triangle[] allTriangles = { triangle1, triangle2, triangle3, triangle4 };
            foreach (var figureTriangle in allTriangles)
            {
                Console.WriteLine(figureTriangle.GetSquare().ToString());
            }
            Rectangle[] allRectangles = { rectangle1, rectangle2 };
            foreach (var figureRectangle in allRectangles)
            {
                Console.WriteLine(figureRectangle.GetSquare().ToString());
            }
            Console.WriteLine();

            //HOSPITAL
            Console.WriteLine("TASK HOSPITAL");
            Patient firstPatient = new Patient("Ivan", new PlanOfThreatment(1).treatIndex);
            firstPatient.doctorSelection();
            Patient secondPatient = new Patient("Anatoli", new PlanOfThreatment(2).treatIndex);
            secondPatient.doctorSelection();
            Patient thirdPatient = new Patient("Alex", new PlanOfThreatment(88).treatIndex);
            thirdPatient.doctorSelection();
        }
    }
}
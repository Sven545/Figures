using System;

namespace FiguresClassLibrary
{
 
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRectangular { get; private set; }
        public Triangle(double sideA, double sideB, double sideC)
        {

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            ExistenceCheck();
            RectangularityCheck();

        }
        public override double GetArea()
        {
            return Math.Sqrt(0.5 * GetPerimeter() * (0.5 * GetPerimeter() - SideA) * (0.5 * GetPerimeter() - SideB) * (0.5 * GetPerimeter() - SideC));
        }
        private void ExistenceCheck()
        {
            if ((((SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA)) == false) || (SideA <= 0) || (SideB <= 0) || (SideC <= 0))
            {
                throw new ArgumentException($"Triangle [{SideA},{SideB},{SideC}] does not exist");
            }

        }
        private void RectangularityCheck()
        {
            double sideASquare = Math.Pow(SideA, 2);
            double sideBSquare = Math.Pow(SideB, 2);
            double sideCSquare = Math.Pow(SideC, 2);

            if ((sideASquare + sideBSquare == sideCSquare) || (sideASquare + sideCSquare == sideBSquare) || (sideBSquare + sideCSquare == sideASquare))
            {
                IsRectangular = true;
            }
            else
            {
                IsRectangular = false;
            }
        }
        private double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

    }
}

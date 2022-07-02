using System;

namespace FiguresClassLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius) : base()
        {
            Radius = radius;
            ExistenceCheck();
        }
        public override double GetArea()
        {
            
            return Math.PI * Math.Pow(Radius, 2);
        }

        private void ExistenceCheck()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException($"Circle with radius = 0 does not exist");

            }
        }
    }
}

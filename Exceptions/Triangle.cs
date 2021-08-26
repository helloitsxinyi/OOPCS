using System;
namespace Exceptions
{
    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side3 + side1 > side2))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
                return;
            }
            throw new BadTriangleException("Invalid triangle!");
            
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double Area()
        {
            // Heron's formula
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * s - Side3);            
        }

    }
}

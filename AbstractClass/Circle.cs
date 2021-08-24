using System;
namespace AbstractClass
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

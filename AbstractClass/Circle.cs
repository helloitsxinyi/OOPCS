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
            //can use math.round!
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
    }
}

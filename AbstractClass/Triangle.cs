using System;
namespace AbstractClass
{
    public class Triangle : Shape
    {
        private double width, height;

        public Triangle(string color, double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return 0.5 * width * height;
        }
    }
}

using System;
namespace AbstractClass
{
    public class Rectangle : Shape
    {
        private double width, height;
                
        public Rectangle(string color, double width, double height): base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }


    }
}

using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 10;
            int radius = 2;

            Shape rectangle = new Rectangle("blue", width, height);
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());

            Shape triangle = new Triangle("green", width, height);
            Console.WriteLine("Area of Triangle: " + triangle.Area());

            Shape circle = new Circle("yellow", radius);
            Console.WriteLine("Area of Circle: " + circle.Area());
        }
    }
}

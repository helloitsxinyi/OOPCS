using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // put the try catch in main or BadTriangleException?
            Triangle triangle = new Triangle(7, 10, 5);
            Triangle triangle2 = new Triangle(1, 10 ,12);
        }
    }
}

using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // put the try catch in main or BadTriangleException?
            try
            {
                Triangle triangle = new Triangle(7, 10, 5);
                Console.WriteLine("Area is " + triangle.Area() + ". Perimeter is: " + triangle.Perimeter());
                Triangle triangle2 = new Triangle(1, 10, 12);                
                Console.WriteLine("Area is " + triangle2.Area() + ". Perimeter is: " + triangle2.Perimeter());
            }
            catch (BadTriangleException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}

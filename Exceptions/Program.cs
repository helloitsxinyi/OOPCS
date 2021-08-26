using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = 10 / i;

            // put the try catch in main or BadTriangleException?
            // best to put specific catches in your methods i think, then put a general Exception handler in main to handle any exception.
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

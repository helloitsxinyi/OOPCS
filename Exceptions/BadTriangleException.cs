using System;
namespace Exceptions
{
    public class BadTriangleException : Exception
    {

        public BadTriangleException() : base()
        {
        }

        public BadTriangleException(string message) : base(message)
        {
        }
    }
}

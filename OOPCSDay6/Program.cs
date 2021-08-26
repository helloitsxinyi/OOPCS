using System;

namespace OOPCSDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a divisor");
                string input = Console.ReadLine();
                int divisor = int.Parse(input);
                int quotient = 10 / divisor;
                Console.WriteLine(quotient);
            }
            // can use many catch blocks to catch diff types of errors.
            // try block will break when exception is caught 
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}

using System;
namespace TestPropogation
{
    public class ExcPropagation1
    {
        public void M1()
        {
            try
            {
                Console.WriteLine("Enter try block of M1.");
                M2();
                Console.WriteLine("Exit try block of M1.");
            }
            catch (IndexOutOfRangeException e)
            {
                // not executed at all as the exception is a DivideByZeroException.
                Console.WriteLine("Enter catch block of M1.");          
                Console.WriteLine("Exception from: {0}", e.TargetSite);
                Console.WriteLine("Exit catch block of M1.");
            }
            Console.WriteLine("Exit M1.");
        }
        public void M2()
        {
            Console.WriteLine("Enter M2.");
            int y = 0;
            int x = 10 / y;
            Console.WriteLine("Exit M2.");
        }
    }


}

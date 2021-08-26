using System;

namespace TestPropogation
{
    class TestPropagation
    {
        public static void Main()
        {
            //Enter Main.
            //Enter try block of M1.
            //Enter M2.
            //Enter catch block of Main.
            //Exception from: Void M2()
            //Exit catch block of Main.
            //Exit Main.

            // note that exception caught is usually propogated ot the calling method
            // in this case, it should enter the catch block of m1 if there is DivideByZeroException.
            // h/w m1 here contains IndexOutOfRangeException, so not executed.
            Console.WriteLine("Enter Main.");
            ExcPropagation1 mc = new ExcPropagation1();
            try
            {
                mc.M1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter catch block of Main.");
                // TargetSite gets the method that throws the current exception, ie the method that caused the error.                
                // here, TargetSite is void M2().
                Console.WriteLine("Exception from: {0}",
                           e.TargetSite);
                Console.WriteLine("Exit catch block of Main.");
            }
            Console.WriteLine("Exit Main.");

            //Enter Main.
            //Enter try block of M1.
            //Enter M2.
            //Finally M1.
            //Enter catch block of Main.
            //Exception from: Void M2()
            //Exit catch block of Main.
            //Exit Main.
            Console.WriteLine("Enter Main.");
            ExcPropagation2 mc2 = new ExcPropagation2();
            try
            {
                mc2.M1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter catch block of Main.");
                Console.WriteLine("Exception from: {0}",
                           e.TargetSite);
                Console.WriteLine("Exit catch block of Main.");
            }
            Console.WriteLine("Exit Main.");
        }

    }
}



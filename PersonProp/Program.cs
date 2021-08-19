using System;

namespace PersonProp
{
class Program
    {
        static void Main(string[] args)
        {
            PersonProp gary = new PersonProp("Gary", "Tan", 35, 1.7f);

            // calling properties here, using setter & getter.
            // not directly changing values of attributes!
            gary.LastName = "Wong";
            gary.Age = 36;
            gary.Height = -1.71f;

            Console.WriteLine("Name: " + gary.FirstName + " " + gary.LastName);
            Console.WriteLine("Age: " + gary.Age);
            Console.WriteLine("Height: " + gary.Height + "m");

        }            
    }
}


using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person gary = new Person("Gary", "Tan", 35, 1.7f);
            gary.sayHi();
            gary.sayAge();
            gary.sayHeight();

            // new line for output separation
            Console.WriteLine("");

            Person jane = new Person("Jane", "Yong", 23, 1.6f);
            jane.sayHi();
            jane.sayAge();
            jane.sayHeight();
        }
    }
}

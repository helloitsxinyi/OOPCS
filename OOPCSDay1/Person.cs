using System;
namespace OOPCSDay1
{
    public class Person
    {
        // instance variable.
        // NOT global variable!
        // member attribute.
        private string name;

        // name is local variable, only visible within the block of code.
        // so can use this.name instead of _name to refer to instance variable. the current object.
        public Person(string name)
        {
            // debugger:
            // this = OOPCSDay1.Person
            // name = "Harry
            this.name = name;        
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating!");

        }

        public void Talk()
        {
            Console.WriteLine(name + " is talking!");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping!");
        }
    }
}

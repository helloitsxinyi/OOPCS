using System;
namespace OOPCSDay1
{
    public class PersonOld
    {
        private string _name;

        // name is local variable, only visible within the block of code.
        // so can use this.name instead of _name to refer to instance variable. the current object.
        public PersonOld(string name)
        {
            _name = name;
            // this.name = name;
        
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");

        }

        public void Talk()
        {
            Console.WriteLine(_name + " is talking!");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping!");
        }
    }
}

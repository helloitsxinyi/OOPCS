using System;
namespace OOPCSDay1
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
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

using System;

namespace OOPCSDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person harry = new Person("Harry");

            harry.Talk();

            Person mary;

            mary = new Person("Mary");
            mary.Talk();
        }
    }
}

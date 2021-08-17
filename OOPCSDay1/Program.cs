using System;

namespace OOPCSDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            // !!! compiler evaluates what is on the RHS first, so that it can assign the completed value into the LHS.
            // constructs harry first.
            Person harry = new Person("Harry");

            harry.Talk();
            

            Person mary;

            mary = new Person("Mary");
            mary.Talk();

            LED ledOne = new LED("red");
            
        }
    }
}

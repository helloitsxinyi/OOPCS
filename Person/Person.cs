using System;
namespace Person
{
    public class Person
    {
        string firstName, lastName;
        int age;
        float height;
        
        public Person(string firstName, string lastName, int age, float height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
        }

        public void sayHi()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}!");
        }

        public void sayAge()
        {
            Console.WriteLine($"I'm {age} years old");
        }

        public void sayHeight()
        {
            Console.WriteLine($"My height is {height}m");
        }
    }
}

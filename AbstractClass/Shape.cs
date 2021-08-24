using System;
namespace AbstractClass
{
    public abstract class Shape
    {
        //can use properties too if you want, else this private attribute is fine too
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        // providing a "core" function for shape
        public string GetColor()
        {
            return color;
        }

        // leave calculation of area to child classes
        public abstract double Area();
    }
}

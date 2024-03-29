﻿using System;
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
        // dictate that return type is double, so even if inputs is int, also ok as long as returned value is double
        public abstract double Area();
    }
}

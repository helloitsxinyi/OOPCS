using System;

namespace ColorLamp
{
    class Program
    {
        static void Main(string[] args)
        {
            LED LEDred = new LED("red");
            LED LEDgreen = new LED("green");
            LED LEDblue = new LED("blue");
            ColorLamp lamp = new ColorLamp(LEDred, LEDgreen, LEDblue);

            for (int i = 0; i < 10; i++)
            {
                lamp.turnOn();
                lamp.turnOn();
                Console.WriteLine("Color: " + lamp.getCurrColor());
                lamp.turnOff();
            }
        }
    }
}

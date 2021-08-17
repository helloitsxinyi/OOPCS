using System;
namespace ColorLamp
{
    public class ColorLamp
    {
        private LED red, green, blue;
        private LED current;

        public ColorLamp(LED red, LED green, LED blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            current = null;
        }

        public void turnOff()
        {

        }
    }
}

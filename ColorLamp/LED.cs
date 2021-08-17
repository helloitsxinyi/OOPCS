using System;
namespace ColorLamp
{
    public class LED
    {        
        private string color;
        private bool isOn;

        public LED(string color)
        {
            this.color = color;
            this.isOn = false;
        }

        public string getColor()
        {
            return color;
        }

        public bool isLEDOn()
        {           
            return isOn;
        }

        public void turnOn()
        {
            // good to include the checks to make it more thorough.
            // method using method within its own class
            // if (! isLEDOn())
            if (isOn != true)
            {
                isOn = true;
            }           
        }

        public void turnOff()
        {
            if (isLEDOn())
            {
                isOn = false;
            }      
        }

        // even simpler
        public void toggleOnOff()
        {
            isOn = !isOn;
        }

    }
}

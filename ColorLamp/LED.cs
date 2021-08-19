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
            // don't need this.isOn because no local variable in this method.
            // only local variable is color, so to differentiate between local and member attribute, need to put this. (this points to current object)
            isOn = false;
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
            if (!isLEDOn()) 
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
    }
}

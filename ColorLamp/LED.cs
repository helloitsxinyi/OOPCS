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

        public string GetColor()
        {
            return color;
        }

        public bool IsLEDOn()
        {
           
            return isOn;
        }

        public void TurnOn()
        {
            if (!IsLEDOn()) 
            {
                isOn = true;
            }           
        }

        public void TurnOff()
        {
            if (IsLEDOn())
            {
                isOn = false;
            }      
        }
    }
}

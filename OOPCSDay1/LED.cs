using System;
namespace OOPCSDay1
{
    public class LED
    {
        // better to use private instead of public. not wrong though
        // don't want to assign the color bc then the whole lifetime of the programme, it will be that color.
        private string color;
        public bool isOn;

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
            // don't need return this.isOn because there is no local variable, im still inside the object.
            // cannot find any local variable, so it looks at the instance attribute.
            // this.isOn also works, but can be simplified
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

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

     
        }

        public void turnOn()
        {
       



        }

        public void turnOff()
        {
         

        }

        public string getCurrColor()
        {
            // refer to LED object!
            return current.getColor();
        }
    }
}

using System;

namespace Command
{
    public class GarageDoor 
    {
        public void Up()
        {
            Console.WriteLine("Door is Open");
        }   
        public void Down()
        {
            Console.WriteLine("Door is Closed");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void LightOn()
        {

        }
        public void LightOff()
        {

        }
    }
}

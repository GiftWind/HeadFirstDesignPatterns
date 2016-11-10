using System;

namespace Command
{
    class RemoteControlTest
    {
        public static void Main()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor(); 
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.Slot = lightOn;
            remote.ButtonWasPressed();
            remote.Slot = garageDoorOpen;
            remote.ButtonWasPressed();
            Console.ReadLine();
        }
    }
}

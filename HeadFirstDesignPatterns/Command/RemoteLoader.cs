using System;

namespace Command
{
    class RemoteLoader
    {
        public static void Main()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living room");
            Light kitchenLight = new Light("Kitchen Light");
            CeilingFan ceilingFan = new CeilingFan("Living room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanHigh = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
           
            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            remoteControl.UndoButtonWasPressed();
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPressed(2);
            remoteControl.UndoButtonWasPressed();
            remoteControl.OnButtonWasPressed(3);
            remoteControl.OffButtonWasPressed(3);
            remoteControl.UndoButtonWasPressed();

            Console.ReadLine();
        }
    }
}

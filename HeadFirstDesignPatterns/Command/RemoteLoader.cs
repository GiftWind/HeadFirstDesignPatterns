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
            TV tv = new TV("Living room");
            Hottub hottub = new Hottub();

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

            TVOnCommand tvOn = new TVOnCommand(tv);
            TVOffCommand tvOff = new TVOffCommand(tv);

            HottubOnCommand hottubOn = new HottubOnCommand(hottub);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCD, tvOn, hottubOn };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff, tvOff, hottubOff };

            //TODO: deal with the Macrocommand name
            Macrocommand partyOnMacro = new Macrocommand(partyOn);
            Macrocommand partyOffMacro = new Macrocommand(partyOff);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(4, partyOnMacro, partyOffMacro);
           
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
            remoteControl.OnButtonWasPressed(4);
            Console.WriteLine("Party is on!");
            remoteControl.OffButtonWasPressed(4);
            Console.WriteLine("Party is over");


            Console.ReadLine();
        }
    }
}

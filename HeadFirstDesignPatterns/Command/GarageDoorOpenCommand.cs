namespace Command
{
    class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor GarageDoor { get; private set; }
        public void Execute()
        {
            GarageDoor.Up();
        }
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
    }
}

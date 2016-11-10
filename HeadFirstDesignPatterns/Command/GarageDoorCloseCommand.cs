namespace Command
{
    class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor GarageDoor { get; private set; }

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute()
        {
            GarageDoor.Down();
        }
    }
}

namespace Command
{
    class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor GarageDoor { get; set; }
        public void Execute()
        {
            GarageDoor.Up();
        }
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.GarageDoor = garageDoor;
        }
    }
}

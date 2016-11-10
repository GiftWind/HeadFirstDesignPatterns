namespace Command
{
    class CeilingFanOffCommand : ICommand
    {
        public CeilingFan CeilingFan { get; private set; }

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            CeilingFan.Off();
        }
    }
}

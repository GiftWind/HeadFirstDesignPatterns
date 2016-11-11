namespace Command
{
    internal class CeilingFanOnCommand : ICommand
    {
        CeilingFan CeilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            CeilingFan.On();
        }
    }
}
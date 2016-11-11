namespace Command
{
    class CeilingFanHighCommand : ICommand
    {
        CeilingFan _ceilingFan;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.High();
        }
    }
}

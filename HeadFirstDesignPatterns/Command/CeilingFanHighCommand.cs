namespace Command
{
    class CeilingFanHighCommand : ICommand
    {
        CeilingFan _ceilingFan;
        int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }

        public void Undo()
        {
            _ceilingFan.Speed = _prevSpeed;
        }
    }
}

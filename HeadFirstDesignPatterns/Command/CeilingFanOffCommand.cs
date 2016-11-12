namespace Command
{
    class CeilingFanOffCommand : ICommand
    {
        CeilingFan _ceilingFan;
        int _prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Off();
        }

        public void Undo()
        {
            _ceilingFan.On();
            _ceilingFan.Speed = _prevSpeed;
        }
    }
}

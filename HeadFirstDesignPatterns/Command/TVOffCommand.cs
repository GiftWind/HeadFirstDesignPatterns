namespace Command
{
    class TVOffCommand : ICommand
    {
        TV _tv;
        public TVOffCommand(TV tv)
        {
            _tv = tv; 
        }
        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}

namespace Command
{
    class HottubOffCommand : ICommand
    {
        Hottub _hottub;
        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void Execute()
        {
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.On();
        }
    }
}

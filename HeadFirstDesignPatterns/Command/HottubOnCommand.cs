namespace Command
{
    class HottubOnCommand : ICommand
    {
        Hottub _hottub;
        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void Execute()
        {
            _hottub.On();
        }

        public void Undo()
        {
            _hottub.Off();
        }
    }
}

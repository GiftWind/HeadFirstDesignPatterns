namespace Command
{
    class Macrocommand : ICommand
    {
        public ICommand[] Commands { get; private set; }
        public Macrocommand(ICommand[] commands)
        {
            Commands = commands;
        }
        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in Commands)
            {
                command.Undo();
            }
        }
    }
}

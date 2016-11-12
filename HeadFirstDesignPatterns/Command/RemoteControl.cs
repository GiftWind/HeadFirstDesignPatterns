using System.Text;

namespace Command
{
    class RemoteControl
    {
        ICommand[] OnCommands;
        ICommand[] OffCommands;
        ICommand UndoCommand;

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            ICommand NoCommand = new NoCommand();
            for (int i = 0; i < OnCommands.Length; i++)
            {
                OnCommands[i] = NoCommand;
                OffCommands[i] = NoCommand;
            }
            UndoCommand = NoCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            OnCommands[slot].Execute();
            UndoCommand = OnCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            OffCommands[slot].Execute();
            UndoCommand = OffCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            UndoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < OnCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {OnCommands[i].GetType().Name} {OffCommands[i].GetType().Name}\n");
            }
            return sb.ToString();
        }

    }
}

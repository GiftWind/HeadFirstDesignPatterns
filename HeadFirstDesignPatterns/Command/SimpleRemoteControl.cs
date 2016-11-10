namespace Command
{
    class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}

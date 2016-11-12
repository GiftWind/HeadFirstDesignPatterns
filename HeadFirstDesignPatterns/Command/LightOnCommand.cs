namespace Command
{
    class LightOnCommand : ICommand
    {
        Light _light;

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }

        public LightOnCommand(Light light)
        {
            _light = light;
        }
    }
}

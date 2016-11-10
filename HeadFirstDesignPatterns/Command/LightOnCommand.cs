namespace Command
{
    class LightOnCommand : ICommand
    {
        public Light Light { get; private set; }

        public void Execute()
        {
            Light.On();
        }

        public LightOnCommand(Light light)
        {
            Light = light;
        }
    }
}

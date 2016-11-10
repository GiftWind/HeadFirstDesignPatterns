namespace Command
{
    class LightOnCommand : ICommand
    {
        public Light Light { get; set; }

        public void Execute()
        {
            Light.On();
        }

        public LightOnCommand(Light light)
        {
            this.Light = light;
        }
    }
}

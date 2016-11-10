namespace Command
{
    class LightOffCommand : ICommand
    {
        public Light Light { get; private set; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }
    }
}
